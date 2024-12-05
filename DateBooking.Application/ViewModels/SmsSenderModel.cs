namespace DateBooking.Application.ViewModels;

public class SmsSenderModel
{
    public required string PhoneNumber { get; set; }
    public string Message { get; set; } = "You have got an email from customer.";
}