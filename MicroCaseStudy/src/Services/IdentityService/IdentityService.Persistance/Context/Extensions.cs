using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityService.Persistance.Context;

public static class Extensions
{
    public static IServiceCollection UseMigration(this IServiceCollection services)
    {
        using var scope = services.BuildServiceProvider().CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<IdentityServiceDbContext>();
        dbContext.Database.Migrate(); // Async olmayan versiyonunu kullanıyoruz
        return services;
    }
}