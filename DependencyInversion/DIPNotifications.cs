namespace DependencyInversion
{
    using DependencyInversion.Interface;

    public class DIPNotifications
    {
        private readonly IMessage message;

        public DIPNotifications(IMessage message) => this.message = message;

        public string GetEmail() => message.SendMessage();

        public string GetSMS() => message.SendMessage();
    }
}
