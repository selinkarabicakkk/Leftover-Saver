using AutoMapper;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Features.Restaurant.Command.CreateRestaurant;
using CleanArchitecture.Core.Features.Restaurant.Query.GetAllRestaurants;
//using CleanArchitecture.Core.Features.Categories.Queries.GetAllCategories;
//using CleanArchitecture.Core.Features.Products.Commands.CreateProduct;
//using CleanArchitecture.Core.Features.Products.Queries.GetAllProducts;

namespace CleanArchitecture.Core.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            /*  CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
              CreateMap<CreateProductCommand, Product>();
              CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
              CreateMap<GetAllCategoriesQuery, GetAllCategoriesParameter>();
              CreateMap<Category, GetAllCategoriesViewModel>().ReverseMap();
            */

            CreateMap<Restaurant, GetAllRestaurantsViewModel>().ReverseMap();
            CreateMap<CreateRestaurantCommand, Restaurant>();
            CreateMap<GetAllRestaurantsQuery, GetAllRestaurantsParameter>();
        }
    }
}
