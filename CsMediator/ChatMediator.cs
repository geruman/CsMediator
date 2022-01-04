using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsMediator
{
    public class ChatMediator
    {
        private IDictionary<string, User> users;
        private List<Message> messages;
        public ChatMediator()
        {
            users = new Dictionary<string, User>();
            messages = new List<Message>();
        }
        public string GetAllMessages()
        {
            string text = "";
            foreach(Message message in messages)
            {
                text = text + "\n From("+message.Sender.Name+") to ("+message.Receiver.Name+") " + message.MessageString;
            }
            return text;
        }
        public void SendMessage(User sender, User receiver, string message)
        {
            Message msg = new Message(sender, receiver, message);
            if (users.ContainsKey(sender.Name))
            {
                messages.Add(msg);
                users[receiver.Name].ReceiveMessage(msg);
            }
        }
        public void AddUser(User user)
        {
            if (!users.ContainsKey(user.Name))
            {
                users.Add(user.Name, user);
            }
        }
    }
}
