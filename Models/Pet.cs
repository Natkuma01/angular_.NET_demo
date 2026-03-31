using System.ComponentModel.DataAnnotations;

namespace PetCareApp.Api.Models;

public class Pet
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Breed { get; set; }

    public int OwnerId { get; set; }

    public List<PetTask> Tasks { get; set; } = new List<PetTask>();
}