namespace _05_SOLID.DIP.Good
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    public class EmailService : IMessageService
    {
        public void SendMessage(string message) =>
            Console.WriteLine($"Email sent: {message}");
    }

    public class SMSService : IMessageService
    {
        public void SendMessage(string message) =>
            Console.WriteLine($"SMS sent: {message}");
    }

    public class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Send(string msg) => _messageService.SendMessage(msg);
    }
}