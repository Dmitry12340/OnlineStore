using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.AppServices.Authentication.Services;
using OnlineStore.AppServices.Common.Redis;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.DataAccess.Common;
using OnlineStore.DataAccess.Product.Repositories;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Mappings;

namespace OnlineStore.ComponentRegistar
{
    /// <summary>
    /// Класс регистрации компонентов приложения
    /// </summary>
    public static class OnlineStoreRegistrar
    {
        public static void AddComponents(IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<OnlineStoreDbContext>()
                .AddDefaultTokenProviders();


            RegisterRepositories(services, configuration);
            RegisterServices(services);
            RegisterMapper(services, configuration);
        }

        private static void RegisterRepositories(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<OnlineStoreDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<IProductRepository,  ProductRepository>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IRedisCache, RedisCache>();

            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddScoped<IProductService, ProductService>();
        }

        private static void RegisterMapper(IServiceCollection services, IConfiguration configuration)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ProductAttributeMappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
