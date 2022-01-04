using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsMediator;
namespace MediatorForms
{
    public partial class Form1 : Form
    {
        ChatMediator chatMediator;
        User user1 = new User("Jorge");
        User user2 = new User("Pedro");
        public Form1()
        {
            chatMediator = new ChatMediator();
            InitializeComponent();
            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            user1.ChatMediator = chatMediator;
            user2.ChatMediator = chatMediator;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sendMessage1_Click(object sender, EventArgs e)
        {
            user1.SendMessage(user1Message.Text, user2);
            user1Message.Text = "";
            MostrarMensajes();
        }
        private void MostrarMensajes()
        {
            allMessages.Text = chatMediator.GetAllMessages();
            pedroTextBox.Text = user2.GetAllMessages();
            jorgeTextBox.Text = user1.GetAllMessages();
        }

        private void sendMessage2_Click(object sender, EventArgs e)
        {
            user2.SendMessage(user2Message.Text, user1);
            user2Message.Text = "";
            MostrarMensajes();
        }
    }
}
