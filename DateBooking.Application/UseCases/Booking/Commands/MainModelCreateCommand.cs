using DateBooking.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Application.UseCases.Booking.Commands
{
    public class MainModelCreateCommand: IRequest<ResponseModel>
    {
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
