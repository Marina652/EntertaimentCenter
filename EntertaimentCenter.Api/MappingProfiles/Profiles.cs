using AutoMapper;
using EntertaimentCenter.Api.Models.Client;
using EntertaimentCenter.Api.Models.Discount;
using EntertaimentCenter.Api.Models.DiscountCard;
using EntertaimentCenter.Api.Models.Event;
using EntertaimentCenter.Api.Models.Order;
using EntertaimentCenter.Api.Models.Place;
using EntertaimentCenter.Application.Entities;

namespace EntertaimentCenter.Api.MappingProfiles;

public class Profiles : Profile
{
    public Profiles()
    {
        CreateMap<RequestCustomEventModel, CustomEvent>().ReverseMap();
        CreateMap<ResponseCustomEventModel, CustomEvent>().ReverseMap();

        CreateMap<RequestClientModel, Client>().ReverseMap();
        CreateMap<ResponceClientModel, Client>().ReverseMap();

        CreateMap<RequestOrderModel, Order>().ReverseMap();
        CreateMap<ResponceOrderModel, Order>().ReverseMap();

        CreateMap<RequestPlaceModel, Place>().ReverseMap();
        CreateMap<ResponcePlaceModel, Place>().ReverseMap();

        CreateMap<RequestDiscountModel, Discount>().ReverseMap();
        CreateMap<ResponceDiscountModel, Discount>().ReverseMap();

        CreateMap<RequestDiscountCardModel, DiscountCard>().ReverseMap();
        CreateMap<ResponceDiscountCardModel, DiscountCard>().ReverseMap();
    }
}
