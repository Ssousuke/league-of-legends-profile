using LOLProfile.Application.Mappings;
using LOLProfile.Application.Services;
using LOLProfile.Application.Services.IServices;
using LOLProfile.Domain.Interface;
using LOLProfile.Infra.Data.Context;
using LOLProfile.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LOLProfile.Infra.IoC
{
    public static class IoC
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ContextDb>(options => options
               .UseSqlServer(config.GetConnectionString("Dev"), x => x
                   .MigrationsAssembly(typeof(ContextDb).Assembly.FullName)));


            services.AddScoped<ISummonerRepository, SummonerRepository>();
            services.AddScoped<ISummonerService, SummonerService>(); 
            
            services.AddScoped<ILeagueRepository, LeagueRepository>();
            services.AddScoped<ILeagueService, LeagueService>();


            services.AddAutoMapper(typeof(DomainToMappingDtoProfile));

            return services;
        }
    }
}