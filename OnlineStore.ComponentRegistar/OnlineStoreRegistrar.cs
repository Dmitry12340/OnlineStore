﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.AppServices.Authentication.Services;
using OnlineStore.AppServices.Common.Redis;
using OnlineStore.AppServices.Mediator.Product.Commands;
using OnlineStore.AppServices.Mediator.Product.Handlers;
using OnlineStore.AppServices.Product.Repositories;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.AppServices.ProductImage.Repositories;
using OnlineStore.AppServices.ProductImage.Services;
using OnlineStore.AppServices.Roles.Services;
using OnlineStore.AppServices.UserRoles.Services;
using OnlineStore.DataAccess.Common;
using OnlineStore.DataAccess.Product.Repositories;
using OnlineStore.DataAccess.ProductImage.Repositories;
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
            RegisterMediator(services);
        }

        private static void RegisterRepositories(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<OnlineStoreDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IProductImagesRepository, ProductImagesRepository>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IRedisCache, RedisCache>();

            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IProductImagesService, ProductImagesService>();

            services.AddScoped<IRolesService, RolesService>();

            services.AddScoped<IUserRolesService, UserRolesService>();
        }

        private static void RegisterMapper(IServiceCollection services, IConfiguration configuration)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ProductAttributeMappingProfile());
                mc.AddProfile(new ProductMappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void RegisterMediator(IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(OnlineStoreRegistrar).Assembly));

            // Регистрация обработчиков
            services.AddTransient<IRequestHandler<AddProductCommand>, AddProductCommandHandler>();
        }
    }
}
