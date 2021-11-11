using Microsoft.Extensions.DependencyInjection;

namespace FoodEtu.Infrastructure;
public static class Setup
{
    public static IServiceCollection AddFoodEtuInfrastructure(this IServiceCollection services)
        => services.AddDbContext<FoodEtuDbContext>();
}
