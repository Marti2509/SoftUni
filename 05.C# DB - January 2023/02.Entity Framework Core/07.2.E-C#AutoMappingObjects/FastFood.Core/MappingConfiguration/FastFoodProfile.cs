namespace FastFood.Core.MappingConfiguration
{
    using AutoMapper;
    using FastFood.Core.ViewModels.Items;
    using FastFood.Models;

    using ViewModels.Categories;
    using ViewModels.Positions;

    public class FastFoodProfile : Profile
    {
        public FastFoodProfile()
        {
            //Positions
            CreateMap<CreatePositionInputModel, Position>()
                .ForMember(m => m.Name, opt => opt.MapFrom(p => p.PositionName));

            CreateMap<Position, PositionsAllViewModel>();

            //Categories
            CreateMap<CreateCategoryInputModel, Category>()
                .ForMember(m => m.Name, opt => opt.MapFrom(c => c.CategoryName));

            CreateMap<Category, CategoryAllViewModel>();

            CreateMap<Category, CreateItemViewModel>()
                .ForMember(d => d.CategoryId, opt => opt.MapFrom(src => src.Id));

            //Items
            CreateMap<CreateItemInputModel, Item>();

            CreateMap<Item, ItemsAllViewModels>()
                .ForMember(d => d.Category, opt => opt.MapFrom(src => src.Category.Name));
        }
    }
}
