﻿using DateBooking.Application.UseCases.ExternalServices.EmailSender;
using DateBooking.Application.UseCases.ExternalServices.SmsSender;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Application
{
    public static class DateBookingApllicationDbContext
    {
        public static IServiceCollection AddDateBookingApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<ITwilioSmsSender, TwilioSmsSender>();
            return services;
        }
    }
}
