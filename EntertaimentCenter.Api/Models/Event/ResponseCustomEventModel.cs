using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Api.Models.Event;

public class ResponseCustomEventModel
{
    public int Id { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }
}
