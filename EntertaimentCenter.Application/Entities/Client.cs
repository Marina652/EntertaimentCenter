using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Application.Entities;

public class Client : BaseEntity
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [StringLength(100)]
    public string Login { get; set; }

    [Required]
    [StringLength(100)]
    [PasswordPropertyText]
    public string Password { get; set; }

    [Phone]
    [Required]
    [StringLength(15)]
    public string Phone { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; }
}
