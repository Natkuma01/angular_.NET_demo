using System.ComponentModel.DataAnnotations;

namespace PetCareApp.Api.Models;

public class PetTask
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Description { get; set; } = string.Empty;

    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }

    public int PetId { get; set; }
}