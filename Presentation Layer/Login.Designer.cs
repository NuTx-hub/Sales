namespace Presentation_Layer
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            pSelectUser = new Panel();
            btnClient = new RoundButton();
            pSelectUser.SuspendLayout();
            SuspendLayout();
            // 
            // pSelectUser
            // 
            pSelectUser.BackColor = Color.FromArgb(241, 239, 232);
            pSelectUser.Controls.Add(btnClient);
            pSelectUser.Location = new Point(187, 162);
            pSelectUser.Name = "pSelectUser";
            pSelectUser.Size = new Size(350, 380);
            pSelectUser.TabIndex = 0;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(103, 56);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(159, 62);
            btnClient.TabIndex = 0;
            btnClient.Text = "roundButton1";
            btnClient.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(729, 689);
            Controls.Add(pSelectUser);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            Resize += Login_Resize;
            pSelectUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pSelectUser;
        private RoundButton btnClient;
    }
}