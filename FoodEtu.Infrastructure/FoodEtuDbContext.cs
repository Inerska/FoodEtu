using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodEtu.Infrastructure;
public class FoodEtuDbContext
    : IdentityDbContext<IdentityUser>
{
    public FoodEtuDbContext(DbContextOptions<FoodEtuDbContext> options)
        : base(options)
    {
    }
}
