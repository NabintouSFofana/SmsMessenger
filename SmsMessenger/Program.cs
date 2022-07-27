// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure
        string accountSid = Environment.GetEnvironmentVariable("Twiliosid");
        string authToken = Environment.GetEnvironmentVariable("Twilioauth");

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: "Test message from Nabie",
            from: new Twilio.Types.PhoneNumber("your number"),
            to: new Twilio.Types.PhoneNumber("receiver number")
        );

        Console.WriteLine(message.Sid);
    }
}
