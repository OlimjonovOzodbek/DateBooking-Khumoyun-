using DateBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Application.Abstractions
{
    public interface IApplicationDBContext
    {
        public DbSet<MainModel> MainModels { get; set; }
        ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken = default!);
    }
}
