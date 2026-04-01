using Microsoft.EntityFrameworkCore;
using PetCareApp.Api.Models;

namespace PetCareApp.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<PetTask> Tasks { get; set; }
}

