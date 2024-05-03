﻿using ControleDeAcessos.Data.Domain.Interfaces;
using ControleDeAcessos.Repositories;
using ControleDeAcessos.Services.Intefaces;
using ControleDeAcessos.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAcessos;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        // Interfaces Repositories
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IAccessDataRepository, AccessDataRepository>();

        // Interfaces Services
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IAccessDataService, AccessDataService>();

        return services;
    }
}
