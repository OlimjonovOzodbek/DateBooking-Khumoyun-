using DateBooking.Application.Abstractions;
using DateBooking.Application.UseCases.Booking.Commands;
using DateBooking.Application.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Application.UseCases.Booking.Handlers
{
    public class MainModelDeleteCommandHandler : IRequestHandler<MainModelDeleteCommand, ResponseModel>
    {
        private readonly IApplicationDBContext _context;

        public MainModelDeleteCommandHandler(IApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(MainModelDeleteCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var main = await _context.MainModels.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (main == null)
                    throw new Exception();

                _context.MainModels.Remove(main);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel()
                {
                    Message = "Deleted",
                    StatusCode = 200,
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel()
                {
                    Message = "Error",
                    StatusCode = 200,
                    IsSuccess = false
                };
            }
        }
    }
}
