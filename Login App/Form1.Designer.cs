namespace Login_App
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userText = new TextBox();
            passText = new TextBox();
            okbutton = new Button();
            cancelbutton = new Button();
            usernamelabel = new Label();
            passwordlabel = new Label();
            SuspendLayout();
            // 
            // userText
            // 
            userText.Location = new Point(244, 60);
            userText.Name = "userText";
            userText.Size = new Size(100, 23);
            userText.TabIndex = 0;
            // 
            // passText
            // 
            passText.Location = new Point(244, 101);
            passText.Name = "passText";
            passText.Size = new Size(100, 23);
            passText.TabIndex = 1;
            // 
            // okbutton
            // 
            okbutton.BackColor = Color.DarkGreen;
            okbutton.Location = new Point(176, 156);
            okbutton.Name = "okbutton";
            okbutton.Size = new Size(92, 32);
            okbutton.TabIndex = 2;
            okbutton.Text = "Login ";
            okbutton.UseVisualStyleBackColor = false;
            okbutton.Click += okbutton_Click;
            // 
            // cancelbutton
            // 
            cancelbutton.BackColor = Color.Red;
            cancelbutton.Location = new Point(271, 156);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(92, 32);
            cancelbutton.TabIndex = 3;
            cancelbutton.Text = "Cancel";
            cancelbutton.UseVisualStyleBackColor = false;
            cancelbutton.Click += cancelbutton_Click_1;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamelabel.ForeColor = SystemColors.ControlLight;
            usernamelabel.Location = new Point(147, 62);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(91, 21);
            usernamelabel.TabIndex = 4;
            usernamelabel.Text = "Username ";
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordlabel.ForeColor = SystemColors.Control;
            passwordlabel.Location = new Point(156, 99);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(82, 21);
            passwordlabel.TabIndex = 5;
            passwordlabel.Text = "Password";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(527, 392);
            Controls.Add(passwordlabel);
            Controls.Add(usernamelabel);
            Controls.Add(cancelbutton);
            Controls.Add(okbutton);
            Controls.Add(passText);
            Controls.Add(userText);
            Name = "loginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userText;
        private TextBox passText;
        private Button okbutton;
        private Button cancelbutton;
        private Label usernamelabel;
        private Label passwordlabel;
    }
}
