using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Api.Models.Event;

public class RequestCustomEventModel
{
    [Required]
    public string Description { get; set; }

    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }
}
