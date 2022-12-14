using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntertaimentCenter.Api.Models.Client;

public class RequestClientModel
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
