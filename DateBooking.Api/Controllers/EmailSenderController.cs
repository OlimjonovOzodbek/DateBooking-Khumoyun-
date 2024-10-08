using DateBooking.Application.UseCases.ExternalServices.EmailSender;
using DateBooking.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DateBooking.Api.Controllers
{
    [Route("api/emailSenderController")]
    [ApiController]
    public class EmailSenderController : ControllerBase
    {
        private readonly IEmailSender _emailSender;

        public EmailSenderController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task SendMessage([FromBody] MessageModelForEmail model)
        {
            await _emailSender.SendMessageAsync(model);
        }
    }
}
