using DateBooking.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Application.UseCases.Booking.Query
{
    public class GetAllModelsQuery: IRequest<IEnumerable<MainModel>>
    {
    }
}
