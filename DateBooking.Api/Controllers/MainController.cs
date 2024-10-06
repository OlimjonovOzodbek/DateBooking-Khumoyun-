using DateBooking.Application.UseCases.Booking.Commands;
using DateBooking.Application.UseCases.Booking.Query;
using DateBooking.Application.ViewModels;
using DateBooking.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DateBooking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MainController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponseModel> PostMain([FromForm] MainModelCreateCommand command, CancellationToken cancellation)
        {
            var response = await _mediator.Send(command, cancellation);

            return response;
        }
        [HttpGet]
        public async Task<IEnumerable<MainModel>> GetAllModels(CancellationToken cancellation)
        {
            var query = new GetAllModelsQuery();

            var response = await _mediator.Send(query, cancellation);

            return response;
        }
        [HttpDelete]
        public async Task<ResponseModel> Delete(long Id, CancellationToken cancellation)
        {
            var command = new MainModelDeleteCommand { Id = Id };

            var response = await _mediator.Send(command, cancellation);

            return response;
        }
    }
}
