using AutoMapper;
using MarktGuru.Application.Features.Products.Commands.CreateProduct;
using MarktGuru.Application.Features.Products.Commands.UpdateProduct;
using MarktGuru.Application.Features.Products.Queries.GetAllProducts;
using MarktGuru.Domain.Entities;

namespace MarktGuru.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
