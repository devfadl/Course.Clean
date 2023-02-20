using Course.Clean.Application.Contracts;
using Course.Clean.Presistence.DatabaseContext;
using Course.Clean.Presistence.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Course.Clean.Presistence
{
    public static class PresistenceServiceRegistration
    {
        public static IServiceCollection AddPresistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CleanDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRspository>();
            return services;
        }
    }
}