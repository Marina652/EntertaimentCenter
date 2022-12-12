using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Api.Models.Place;

public class ResponcePlaceModel
{
    public int Id { get; set; }

    [Required]
    public int Capacity { get; set; }
}
