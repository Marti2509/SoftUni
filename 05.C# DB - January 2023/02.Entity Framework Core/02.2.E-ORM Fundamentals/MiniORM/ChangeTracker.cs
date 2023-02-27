﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MiniORM
{
    public class ChangeTracker<T>
        where T : class, new()
    {
        private readonly List<T> _allEntities;
        private readonly List<T> _added;
        private readonly List<T> _removed;

        public ChangeTracker(IEnumerable<T> entities)
        {
            _added = new List<T>();
            _removed = new List<T>();
            _allEntities = CloneEntities(entities);
        }

        public IReadOnlyCollection<T> AllEntities => _allEntities.AsReadOnly();
        public IReadOnlyCollection<T> Added => _added.AsReadOnly();
        public IReadOnlyCollection<T> Removed => _removed.AsReadOnly();

        public void Add(T item)
        {
            _added.Add(item);
        }

        public void Remove(T item)
        {
            _removed.Remove(item);
        }

        public IEnumerable<T> GetModifiedEntities(DbSet<T> dbSet)
        {
            var modifiedEntities = new List<T>();
            var primaryKeys = typeof(T).GetProperties()
                .Where(pi => pi.HasAttribute<KeyAttribute>())
                .ToArray();

            foreach (var proxyEntity in AllEntities)
            {
                var primaryKeyValues = GetPrimaryKeyValues(primaryKeys, proxyEntity).ToArray();
                var entity = dbSet.Entities
                    .Single(e => GetPrimaryKeyValues(primaryKeys, e).SequenceEqual(primaryKeyValues));
                var idModified = IsModified(proxyEntity, entity);
                if (idModified)
                {
                    modifiedEntities.Add(proxyEntity);
                }
            }
            return modifiedEntities;
        }

        private static IEnumerable<object> GetPrimaryKeyValues(IEnumerable<PropertyInfo> primaryKeys, T entity)
        {
            return primaryKeys.Select(pk => pk.GetValue(entity));
        }

        private static bool IsModified(T entity, T proxyEntity)
        {
            var monitoredProperties = typeof(T).GetProperties()
                .Where(pi => DbContext.AllowedSqlTypes.Contains(pi.PropertyType));
            var modifiedProperties = monitoredProperties
                .Where(pi => !Equals(pi.GetValue(entity), pi.GetValue(proxyEntity)))
                .ToArray();
            var isModified = modifiedProperties.Any();
            return isModified;
        }

        private static List<T> CloneEntities(IEnumerable<T> entities)
        {
            var clonedEntities = new List<T>();
            var propertiesToClone = typeof(T).GetProperties()
                .Where(pi => DbContext.AllowedSqlTypes.Contains(pi.PropertyType))
                .ToArray();

            foreach (var entity in entities)
            {
                var clonedEntity = Activator.CreateInstance<T>();
                foreach (var proprety in propertiesToClone)
                {
                    var value = proprety.GetValue(entity);
                    proprety.SetValue(clonedEntity, value);
                }
                clonedEntities.Add(entity);
            }
            return clonedEntities;
        }
    }
}