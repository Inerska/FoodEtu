using Microsoft.EntityFrameworkCore;

namespace FoodEtu.Domain;
internal class FoodEtuDbContext
    : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
