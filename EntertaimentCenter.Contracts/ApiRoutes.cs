namespace EntertaimentCenter.Contracts;

public class ApiRoutes
{
    public const string Root = "api";
    public const string Version = "v1";
    public const string Base = Root + "/" + Version;

    public static class CustomEventRoutes
    {
        public const string GetEvents = Base + "/events";
        public const string GetEventById = Base + "/events/{id}";
        public const string CreateEvent = Base + "/events";
        public const string UpdateEvent = Base + "/events";
        public const string DeleteEvent = Base + "/events/{id}";
    }

    public static class ClientRoutes
    {
        public const string GetClients = Base + "/clients";
        public const string GetClientById = Base + "/clients/{id}";
        public const string CreateClient = Base + "/clients";
        public const string UpdateClient = Base + "/clients";
        public const string DeleteClient = Base + "/clients/{id}";
    }

    public static class DiscountRoutes
    {
        public const string GetDiscounts = Base + "/discounts";
        public const string GetDiscountById = Base + "/discounts/{id}";
        public const string CreateDiscount = Base + "/discounts";
        public const string UpdateDiscount = Base + "/discounts";
        public const string DeleteDiscount = Base + "/discounts/{id}";
    }

    public static class DiscountCardRoutes
    {
        public const string GetDiscountCards = Base + "/discountCards";
        public const string GetDiscountCardById = Base + "/discountCards/{id}";
        public const string CreateDiscountCard = Base + "/discountCards";
        public const string UpdateDiscountCard = Base + "/discountCards";
        public const string DeleteDiscountCard = Base + "/discountCards/{id}";
    }

    public static class OrderRoutes
    {
        public const string GetOrders = Base + "/orders";  
        public const string GetOrderById = Base + "/orders/{id}";
        public const string CreateOrder = Base + "/orders";
        public const string UpdateOrder = Base + "/orders";
        public const string DeleteOrder = Base + "/orders/{id}";
    }

    public static class PlaceRoutes
    {
        public const string GetPlaces = Base + "/places"; 
        public const string GetPlaceById = Base + "/places/{id}";
        public const string CreatePlace = Base + "/places";
        public const string UpdatePlace = Base + "/places";
        public const string DeletePlace = Base + "/places/{id}";
    }
}
