using System.ComponentModel.DataAnnotations;

namespace PetCareApp.Api.Models;

public class Owner
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    public List<Pet> Pets { get; set; } = new List<Pet>();
}