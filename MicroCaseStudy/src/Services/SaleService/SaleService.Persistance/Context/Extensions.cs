using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SaleService.Persistance.Context;

public static class Extensions
{
    public static IServiceCollection UseMigration(this IServiceCollection services)
    {
        using var scope = services.BuildServiceProvider().CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<SaleServiceDbContext>();
        dbContext.Database.Migrate(); // Async olmayan versiyonunu kullanıyoruz
        return services;
    }
}