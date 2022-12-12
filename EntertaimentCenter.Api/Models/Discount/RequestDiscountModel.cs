using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Api.Models.Discount;

public class RequestDiscountModel
{
    [Required]
    public decimal Value { get; set; }
}
