﻿using AutoMapper;
using OnlineStore.Contracts;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Mappings
{
    public sealed class ProductAttributeMappingProfile : Profile
    {
        public ProductAttributeMappingProfile()
        {
            CreateMap<ProductAttribute, ProductAttributeDto>()
                .ForMember(dest => dest.FullAttributeName, o => o.MapFrom(src => src.name));
        }
    }
}
