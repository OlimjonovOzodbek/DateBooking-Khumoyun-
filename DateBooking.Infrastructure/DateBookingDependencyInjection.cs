using DateBooking.Application;
using DateBooking.Application.Abstractions;
using DateBooking.Infrastructure.Persistanse;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Infrastructure
{
    public static class DateBookingDependencyInjection
    {
        public static IServiceCollection AddDateBookingDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IApplicationDBContext, DateBookingDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Db"));
            });

            return services;
        }
    }
}
