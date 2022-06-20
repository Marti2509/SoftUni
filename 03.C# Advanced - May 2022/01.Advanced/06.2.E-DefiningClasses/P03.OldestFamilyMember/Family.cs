using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            familyList = new List<Person>();
        }

        public List<Person> familyList { get; set; }

        public void AddMember(Person person)
        {
            familyList.Add(person);
        }

        public Person GetOldestMember()
        {
            int oldest = 0;

            for (int i = 0; i < familyList.Count; i++)
            {
                if (familyList[i].Age > oldest)
                {
                    oldest = i;
                }
            }

            return familyList[oldest];
        }
    }
}
