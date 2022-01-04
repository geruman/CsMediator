using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsMediator
{
    public class User
    {
        public string Name { get; set; }
        private List<Message> messages;
        public List<Message> Messages { get { return messages; } }
        public ChatMediator ChatMediator { get; set; }

        public User(string name)
        {
            Name = name;
            messages = new List<Message>();
        }
        public void ReceiveMessage(Message message)
        {
            messages.Add(message);
        }
        public Message[] GetMessages()
        {
            return messages.ToArray();
        }
        public void SendMessage(string message, User receiver)
        {
            ChatMediator.SendMessage(this, receiver, message);
        }
        public string GetAllMessages()
        {
            string text = "";
            foreach(Message message in messages)
            {
                text = text + "\n From ("+message.Sender.Name +") "+ message.MessageString;
            }
            return text;
        }
    }
}
