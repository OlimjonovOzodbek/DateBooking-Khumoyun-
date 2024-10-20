using DateBooking.Application.UseCases.ExternalServices.SmsSender;
using DateBooking.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DateBooking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsSenderController(ITwilioSmsSender smsSender) : ControllerBase
    {
        private readonly ITwilioSmsSender _smsSender = smsSender;

        [HttpPost]
        public void SendSMS(SmsSenderModel smsSenderModel)
        {
            _smsSender.SendSms(smsSenderModel.PhoneNumber);
        }
    }
}
