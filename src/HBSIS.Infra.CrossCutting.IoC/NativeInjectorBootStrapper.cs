using AutoMapper;
using HBSIS.Data.Context;
using HBSIS.Data.Repository;
using HBSIS.Data.UoW;
using HBSIS.Domain.Interfaces.Repository;
using HBSIS.Domain.Interfaces.Service;
using HBSIS.Domain.Interfaces.UoW;
using HBSIS.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HBSIS.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASPNET
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            // Domain
            services.AddScoped<IClienteService, ClienteService>();

            // Infra - Data
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DataContext>();
            
        }
    }
}