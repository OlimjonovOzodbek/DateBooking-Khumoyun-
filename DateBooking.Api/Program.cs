using DateBooking.Application;
using DateBooking.Application.UseCases.Booking.Commands;
using DateBooking.Infrastructure;
using MediatR;
namespace DateBooking.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
              {
                 options.AddDefaultPolicy(policy =>
                 {
                        policy.AllowAnyOrigin()
                              .AllowAnyHeader()
                              .AllowAnyMethod();
                 });
              });
                // Add services to the container.
                builder.Services.AddDateBookingApplicationDependencyInjection();
            builder.Services.AddDateBookingDependencyInjection(builder.Configuration);
            builder.Services.AddMediatR(typeof(MainModelCreateCommand).Assembly);
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors();


            app.MapControllers();

            app.Run();
        }
    }
}
