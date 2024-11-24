using AutoMapper;
using OnlineStore.Contracts.ProductsDto;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Mappings
{
    public sealed class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Products, ProductsDto>()
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, o => o.MapFrom(src => src.Name))
                .ForMember(dest => dest.Category, o => o.MapFrom(src => src.Category))
                .ForMember(dest => dest.Description, o => o.MapFrom(src => src.Description))
                .ForMember(dest => dest.Price, o => o.MapFrom(src => src.Price))
                .ForMember(dest => dest.Quantity, o => o.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.Images, o => o.MapFrom(src => src.Images));
        }
    }
}