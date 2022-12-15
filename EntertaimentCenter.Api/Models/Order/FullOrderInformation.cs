using EntertaimentCenter.Application.Entities;

namespace EntertaimentCenter.Api.Models.Order;

public class FullOrderInformation
{
    public int OrderId { get; set; }

    public string ClientName { get; set; }

    public string ClientEmail { get; set;}

    public decimal DiscountValue { get; set;}

    public string EventDescription { get; set;}

    public DateTime StartTime { get; set;}

    public int PlaceId { get; set; }

    public string OrderStatus { get; set; }
}
