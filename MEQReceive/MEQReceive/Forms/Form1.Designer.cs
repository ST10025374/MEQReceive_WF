namespace MEQapp
{
    partial class Form1
    {   
        //---------------------------------------------------------------------//
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //---------------------------------------------------------------------//
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetMEQ = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMsg2Snd = new System.Windows.Forms.TextBox();
            this.txtDisplayMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetMEQ
            // 
            this.btnGetMEQ.BackColor = System.Drawing.Color.Black;
            this.btnGetMEQ.ForeColor = System.Drawing.Color.White;
            this.btnGetMEQ.Location = new System.Drawing.Point(361, 196);
            this.btnGetMEQ.Name = "btnGetMEQ";
            this.btnGetMEQ.Size = new System.Drawing.Size(314, 38);
            this.btnGetMEQ.TabIndex = 4;
            this.btnGetMEQ.Text = "Get MEQ";
            this.btnGetMEQ.UseVisualStyleBackColor = false;
            this.btnGetMEQ.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(11, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(321, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Send Quene ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg2Snd
            // 
            this.txtMsg2Snd.Location = new System.Drawing.Point(11, 58);
            this.txtMsg2Snd.Margin = new System.Windows.Forms.Padding(2);
            this.txtMsg2Snd.Multiline = true;
            this.txtMsg2Snd.Name = "txtMsg2Snd";
            this.txtMsg2Snd.Size = new System.Drawing.Size(321, 119);
            this.txtMsg2Snd.TabIndex = 8;
            // 
            // txtDisplayMsg
            // 
            this.txtDisplayMsg.Location = new System.Drawing.Point(361, 58);
            this.txtDisplayMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisplayMsg.Multiline = true;
            this.txtDisplayMsg.Name = "txtDisplayMsg";
            this.txtDisplayMsg.ReadOnly = true;
            this.txtDisplayMsg.Size = new System.Drawing.Size(314, 119);
            this.txtDisplayMsg.TabIndex = 9;
            this.txtDisplayMsg.TextChanged += new System.EventHandler(this.txtDisplayMsg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Whatsapp App";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(686, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDisplayMsg);
            this.Controls.Add(this.txtMsg2Snd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGetMEQ);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMEQ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMsg2Snd;
        private System.Windows.Forms.TextBox txtDisplayMsg;
        private System.Windows.Forms.Label label1;
    }
}
//**------------------------------------------------------------< END >------------------------------------------------------------**// 
