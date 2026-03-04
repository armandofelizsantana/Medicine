using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Medicine.Persistence;
using Medicine.Persistence.Context;
using Medicine.Persistence.Repositories;
using Medicine.Domain.Repositories;

namespace Medicine.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<MedicineDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IBaseRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}