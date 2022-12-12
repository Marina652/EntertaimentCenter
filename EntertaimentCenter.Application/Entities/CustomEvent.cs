using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Application.Entities;

public class CustomEvent : BaseEntity
{
    [Required]
    public string Description { get; set; }

    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }
}
