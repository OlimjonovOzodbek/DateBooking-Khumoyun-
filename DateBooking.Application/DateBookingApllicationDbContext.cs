using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Application
{
    public static class DateBookingApllicationDbContext
    {
        public static IServiceCollection AddDateBookingApplicationDependencyInjection(this IServiceCollection services)
        {
            return services;
        }
    }
}
