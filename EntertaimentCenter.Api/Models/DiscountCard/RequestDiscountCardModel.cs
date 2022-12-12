using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Api.Models.DiscountCard;

public class RequestDiscountCardModel
{

    [Required]
    public int ClientId { get; set; }

    [Required]
    public int DiscountId { get; set; }
}
