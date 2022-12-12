using EntertaimentCenter.Application.DbAccess;
using EntertaimentCenter.Application.Entities;
using EntertaimentCenter.Application.Interfaces;
using EntertaimentCenter.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace EntertaimentCenter.Application;

public static class DI
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DbConnection");

        services.AddDbContext<EntertaimentCenterDbContext>(options =>
              options.UseSqlServer(connectionString));


        services.AddTransient<IServices<BaseEntity>, EntertaimentCenterService<BaseEntity>>();

        services.AddTransient<IServices<Client>, EntertaimentCenterService<Client>>();

        return services;
    }
}
