using System;
using System.Windows.Forms;
using System.Messaging;

namespace MEQapp
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The message queue used for sending and receiving messages.
        /// </summary>
        private MessageQueue MySessageQueue = new MessageQueue();

         
        /// <summary>
        /// The user ID used for some operation.
        /// </summary>
        private int UserID = 0;


        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.MySessageQueue.Path = @".\Private$\MyMessageQueue" + this.UserID;
            this.MySessageQueue.Formatter = new XmlMessageFormatter(new String[]
            { "System.String,mscorlib" });
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Counts the number of messages in the specified message queue.
        /// </summary>
        /// <param name="myQueue">The message queue to count messages from.</param>
        /// <returns>The number of messages in the message queue.</returns>
        private int Count(MessageQueue myQueue)
        {
            int count = 0;
            var emun = myQueue.GetMessageEnumerator2();
            while (emun.MoveNext())
            {
                count++;
            }
            this.Text = "Message Count " + count;
            return count;
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Sends the data to the message queue.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageQueue.Exists(this.MySessageQueue.Path))
                {
                    this.SendData2Queue();
                    //this.Count(this.MySessageQueue);
                }
                else
                {
                    MessageQueue.Create(this.MySessageQueue.Path);
                    this.SendData2Queue();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Sends the data to the message queue.
        /// </summary>
        private void SendData2Queue()
        {
            try
            {
                this.MySessageQueue.Send(this.txtMsg2Snd.Text.Trim() + Emoji.Alien +
                    "\r\n" + DateTime.Now.ToString());
                this.MySessageQueue.Close();
                this.Text = "Message Count: " + this.Count(this.MySessageQueue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.MySessageQueue.Close();
            }
        }

        //---------------------------------------------------------------------//
        /// <summary>
        /// Reads a message from the message queue and displays it in the text box.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageQueue.Exists(this.MySessageQueue.Path))
                {
                    if (this.Count(this.MySessageQueue) > 0)
                    {
                        var message = this.MySessageQueue.Receive();
                        this.txtDisplayMsg.Text = message.Body.ToString();
                        return;
                    }

                }
                this.Count(this.MySessageQueue);
                MessageBox.Show("No message in the queue");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDisplayMsg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 