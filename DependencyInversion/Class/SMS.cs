namespace DependencyInversion.Class
{
    using DependencyInversion.Interface;

    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public string SendMessage()
        {
            string message = string.Empty;

            message += "********** SMS **********\n";
            message += $"Phone: {PhoneNumber}\n";
            message += $"Message: {Message}\n";
            message += "*************************";

            return message;
        }
    }
}
