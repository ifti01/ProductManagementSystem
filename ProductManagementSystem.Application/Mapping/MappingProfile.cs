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
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<UserInfo, UserInfoDto>().ReverseMap();
            // Add more mappings as needed
        }
    }
}
