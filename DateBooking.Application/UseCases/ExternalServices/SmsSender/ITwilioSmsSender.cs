namespace DateBooking.Application.UseCases.ExternalServices.SmsSender
{
    public interface ITwilioSmsSender
    {
        void SendSms(string phoneNumber);
    }
}
