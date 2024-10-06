using DateBooking.Application.Abstractions;
using DateBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Infrastructure.Persistanse
{
    public class DateBookingDbContext : DbContext, IApplicationDBContext
    {
        public DateBookingDbContext(DbContextOptions<DateBookingDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }
        public DbSet<MainModel> MainModels { get; set; }

        async ValueTask<int> IApplicationDBContext.SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
