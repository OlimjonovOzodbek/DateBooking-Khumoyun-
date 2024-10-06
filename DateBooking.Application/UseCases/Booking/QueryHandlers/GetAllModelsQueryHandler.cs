using DateBooking.Application.Abstractions;
using DateBooking.Application.UseCases.Booking.Query;
using DateBooking.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Application.UseCases.Booking.QueryHandlers
{
    public class GetAllModelsQueryHandler : IRequestHandler<GetAllModelsQuery, IEnumerable<MainModel>>
    {
        private IApplicationDBContext _context;

        public GetAllModelsQueryHandler(IApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MainModel>> Handle(GetAllModelsQuery request, CancellationToken cancellationToken)
        {
            return await _context.MainModels.ToListAsync();
        }
    }
}
