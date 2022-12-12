using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Api.Models.Discount;

public class ResponceDiscountModel
{
    public int Id { get; set; }

    [Required]
    public decimal Value { get; set; }
}
