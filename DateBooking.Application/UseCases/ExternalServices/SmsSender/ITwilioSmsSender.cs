using DateBooking.Application.ViewModels;

namespace DateBooking.Application.UseCases.ExternalServices.SmsSender
{
    public interface ITwilioSmsSender
    {
        public void SendSms(SmsSenderModel model);
    }
}
