namespace WebApi.Models;

using System.ComponentModel.DataAnnotations;

public class AuthenticateModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
