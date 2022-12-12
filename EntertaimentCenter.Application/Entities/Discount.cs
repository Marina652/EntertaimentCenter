using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Application.Entities;

public class Discount : BaseEntity
{
    [Required]
    public decimal Value { get; set; }
}
