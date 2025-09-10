namespace _05_SOLID.DIP.Bad
{
    public class EmailService
    {
        public void SendEmail(string message) =>
            Console.WriteLine($"Email sent: {message}");
    }

    public class Notification
    {
        private EmailService emailService = new EmailService();

        public void Send(string msg) => emailService.SendEmail(msg);
    }
}