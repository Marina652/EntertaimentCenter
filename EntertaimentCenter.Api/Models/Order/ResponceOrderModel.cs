using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Api.Models.Order;

public class ResponceOrderModel
{
    public int Id { get; set; }

    [Required]
    public int CustomEventId { get; set; }

    [Required]
    public int PlaceId { get; set; }

    [Required]
    public int ClientId { get; set; }

    [Required]
    public string Status { get; set; }
}
