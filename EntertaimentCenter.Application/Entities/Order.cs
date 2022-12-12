using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Application.Entities;

public class Order : BaseEntity
{
    [Required]
    public int CustomEventId { get; set; }

    [Required]
    public int PlaceId { get; set; }

    [Required]
    public int ClientId { get; set; }

    public ICollection<CustomEvent> CustomEvents { get; set; }

    public ICollection<Place> Places { get; set; }

    public ICollection<Client> Clients { get; set; }
}
