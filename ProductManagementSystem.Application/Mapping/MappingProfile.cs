using AutoMapper;
using ProductManagementSystem.Application.DTOs;
using ProductManagementSystem.Domain.Entities;

namespace ProductManagementSystem.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // Define your mappings here
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Variant, VariantDto>().ReverseMap();
            // Add more mappings as needed
        }
    }
}
