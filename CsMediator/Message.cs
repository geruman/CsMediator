namespace CsMediator
{
    public class Message
    {
        private User sender;
        private User receiver;
        private string messageString;
        public Message(User sender, User receiver, string message)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.messageString = message;
        }
        public User Sender { get { return sender; } }
        public User Receiver { get { return receiver; } }
        public string MessageString { get { return messageString; } }
    }
}