using Microsoft.Extensions.DependencyInjection;

namespace FoodEtu.Domain;
public static class Setup
{
    public static IServiceCollection AddFoodEtuDomain(this IServiceCollection services)
        => services.AddDbContext<FoodEtuDbContext>();
}
