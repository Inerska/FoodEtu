using Microsoft.EntityFrameworkCore;

namespace FoodEtu.Infrastructure;
internal class FoodEtuDbContext
    : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
