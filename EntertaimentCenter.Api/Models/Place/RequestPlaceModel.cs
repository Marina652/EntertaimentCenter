using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Api.Models.Place;

public class RequestPlaceModel
{
    [Required]
    public int Capacity { get; set; }
}
