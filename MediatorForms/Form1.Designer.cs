
namespace MediatorForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.user1Message = new System.Windows.Forms.TextBox();
            this.sendMessage1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sendMessage2 = new System.Windows.Forms.Button();
            this.user2Message = new System.Windows.Forms.TextBox();
            this.allMessages = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jorgeTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pedroTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Jorge";
            // 
            // user1Message
            // 
            this.user1Message.Location = new System.Drawing.Point(12, 37);
            this.user1Message.Name = "user1Message";
            this.user1Message.Size = new System.Drawing.Size(236, 22);
            this.user1Message.TabIndex = 1;
            // 
            // sendMessage1
            // 
            this.sendMessage1.Location = new System.Drawing.Point(264, 35);
            this.sendMessage1.Name = "sendMessage1";
            this.sendMessage1.Size = new System.Drawing.Size(146, 23);
            this.sendMessage1.TabIndex = 2;
            this.sendMessage1.Text = "Enviar Mensaje";
            this.sendMessage1.UseVisualStyleBackColor = true;
            this.sendMessage1.Click += new System.EventHandler(this.sendMessage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(923, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Pedro";
            // 
            // sendMessage2
            // 
            this.sendMessage2.Location = new System.Drawing.Point(1178, 37);
            this.sendMessage2.Name = "sendMessage2";
            this.sendMessage2.Size = new System.Drawing.Size(146, 23);
            this.sendMessage2.TabIndex = 5;
            this.sendMessage2.Text = "Enviar Mensaje";
            this.sendMessage2.UseVisualStyleBackColor = true;
            this.sendMessage2.Click += new System.EventHandler(this.sendMessage2_Click);
            // 
            // user2Message
            // 
            this.user2Message.Location = new System.Drawing.Point(926, 39);
            this.user2Message.Name = "user2Message";
            this.user2Message.Size = new System.Drawing.Size(236, 22);
            this.user2Message.TabIndex = 4;
            // 
            // allMessages
            // 
            this.allMessages.Location = new System.Drawing.Point(446, 42);
            this.allMessages.Name = "allMessages";
            this.allMessages.Size = new System.Drawing.Size(461, 329);
            this.allMessages.TabIndex = 6;
            this.allMessages.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mensajes";
            // 
            // jorgeTextBox
            // 
            this.jorgeTextBox.Location = new System.Drawing.Point(12, 117);
            this.jorgeTextBox.Name = "jorgeTextBox";
            this.jorgeTextBox.Size = new System.Drawing.Size(416, 254);
            this.jorgeTextBox.TabIndex = 8;
            this.jorgeTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mensajes recibidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(926, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mensajes recibidos";
            // 
            // pedroTextBox
            // 
            this.pedroTextBox.Location = new System.Drawing.Point(926, 117);
            this.pedroTextBox.Name = "pedroTextBox";
            this.pedroTextBox.Size = new System.Drawing.Size(416, 254);
            this.pedroTextBox.TabIndex = 10;
            this.pedroTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 383);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pedroTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jorgeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allMessages);
            this.Controls.Add(this.sendMessage2);
            this.Controls.Add(this.user2Message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendMessage1);
            this.Controls.Add(this.user1Message);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MediatorChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user1Message;
        private System.Windows.Forms.Button sendMessage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendMessage2;
        private System.Windows.Forms.TextBox user2Message;
        private System.Windows.Forms.RichTextBox allMessages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox jorgeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox pedroTextBox;
    }
}

