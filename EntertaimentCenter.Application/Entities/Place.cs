using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Application.Entities;

public class Place : BaseEntity
{
    [Required]
    public int Capacity { get; set; }
}
