using Application;
using Application.Business;
using Domain.Repositories;
using Infrastructure.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection;

public static class DiManager
{
    public static IServiceCollection RegisterBusiness(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IOrganizationBusiness, OrganizationBusiness>();
        
        return serviceCollection;
    }
    
    public static IServiceCollection RegisterRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IOrganizationRepository, OrganizationRepository>();
        
        return serviceCollection;
    }
}