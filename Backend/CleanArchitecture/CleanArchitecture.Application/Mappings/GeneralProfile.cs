﻿using AutoMapper;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Features.Item.Command.CreateItem;
using CleanArchitecture.Core.Features.Item.Query.GetAllItem;
using CleanArchitecture.Core.Features.Restaurant.Command.CreateRestaurant;
using CleanArchitecture.Core.Features.Address.Query.GetAllAddresses;//
using CleanArchitecture.Core.Features.Address.Command.CreateAddress;//
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

            CreateMap<Address, GetAllAddressesViewModel>().ReverseMap();
            CreateMap<CreateAddressCommand, Address>();
            CreateMap<GetAllAddressesQuery, GetAllAddressesParameter>();


            CreateMap<Restaurant, GetAllRestaurantsViewModel>().ReverseMap();
            CreateMap<CreateRestaurantCommand, Restaurant>();
            CreateMap<GetAllRestaurantsQuery, GetAllRestaurantsParameter>();

            CreateMap<Item, GetAllItemsViewModel>().ReverseMap();
            CreateMap<CreateItemCommand, Item>();
            CreateMap<GetAllItemsQuery, GetAllItemsParameter>();
        }
    }
}
