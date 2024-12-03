using Microsoft.Extensions.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace DateBooking.Application.UseCases.ExternalServices.SmsSender;
public class TwilioSmsSender : ITwilioSmsSender
{
    private readonly string _accountSid;
    private readonly string _authToken;
    private readonly string _serviceSid;
    private readonly IConfiguration _configuration;

    public TwilioSmsSender(IConfiguration configuration)
    {
        _configuration = configuration;
        _accountSid = _configuration["TwilloSettings:AccountSid"]!;
        _authToken = _configuration["TwilloSettings:AuthToken"]!;
        _serviceSid = _configuration["TwilloSettings:ServiceId"]!;
        TwilioClient.Init(_accountSid, _authToken);
    }

    public void SendSms(string phoneNumber)
    {
        var messageOptions = new CreateMessageOptions(
            new PhoneNumber(phoneNumber));

        messageOptions.From = new PhoneNumber("+19494385214");
        messageOptions.Body = "You have got an email from customer.";

        var message = MessageResource.Create(messageOptions);
        Console.WriteLine($"Message Body: {message.Body}");
    }
}
