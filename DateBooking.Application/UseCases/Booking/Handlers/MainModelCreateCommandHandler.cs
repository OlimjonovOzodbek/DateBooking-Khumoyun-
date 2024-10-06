using DateBooking.Application.Abstractions;
using DateBooking.Application.UseCases.Booking.Commands;
using DateBooking.Application.ViewModels;
using DateBooking.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Application.UseCases.Booking.Handlers
{
    public class MainModelCreateCommandHandler : IRequestHandler<MainModelCreateCommand, ResponseModel>
    {
        private readonly IApplicationDBContext _context;

        public MainModelCreateCommandHandler(IApplicationDBContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<ResponseModel> Handle(MainModelCreateCommand request, CancellationToken cancellationToken)
        {
            var existingEntry = await _context.MainModels
            .Where(m => m.Date == request.Date && m.Time == request.Time)
                .FirstOrDefaultAsync();

            if (existingEntry != null)
            {
                return new ResponseModel()
                {
                    Message = "Already booked",
                    StatusCode = 409, //Conflict
                    IsSuccess = false
                };
            }

            var main = new MainModel()
            {
                Date = request.Date,
                Time = request.Time,
            };

            await _context.MainModels.AddAsync(main);
            await _context.SaveChangesAsync(cancellationToken);

            return new ResponseModel()
            {
                Message = "Created",
                StatusCode = 201,
                IsSuccess = true
            };
        }
    }
}
