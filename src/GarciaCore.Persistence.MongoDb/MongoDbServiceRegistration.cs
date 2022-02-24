﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using GarciaCore.Infrastructure.MongoDb;
using GarciaCore.Domain.MongoDb;

namespace GarciaCore.Persistence.MongoDb
{
    public static class MongoDbServiceRegistration
    {
        public static IServiceCollection AddMongoDbSettings<T>(this IServiceCollection services, IOptions<T> options) where T : MongoDbSettings
        {
            return services.Configure<T>(o =>
            {
                o.ConnectionString = options.Value.ConnectionString;
                o.DatabaseName = options.Value.DatabaseName;
            });
        }
        public static IServiceCollection AddMongoDbSettings(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Configure<MongoDbSettings>(options =>
            {
                string node = options.GetNodeValue();
                options.ConnectionString = configuration.GetSection(node + ":" + options.GetConnectionStringKeyValue()).Value;
                options.DatabaseName = configuration.GetSection(node + ":" + options.GetDatabaseNameKeyValue()).Value;
            });
        }
        public static IServiceCollection AddMongoDbRepository<T>(this IServiceCollection services) where T : MongoDbEntity
        {
            services.AddScoped<IAsyncMongoDbRepository<T>, MongoDbRepository<T>>();
            return services;
        }
    }
}