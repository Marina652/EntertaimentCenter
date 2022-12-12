using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Application.Entities;

public class DiscountCard : BaseEntity
{
    [Required]
    public int ClientId { get; set; }

    [Required]
    public int DiscountId { get; set; }

    public ICollection<Client> Clients { get; set; }

    public ICollection<Discount> Discounts { get; set; }
}
