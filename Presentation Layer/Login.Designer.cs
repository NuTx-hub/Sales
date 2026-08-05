namespace Presentation_Layer
{
    partial class frLogin
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
            btnAdmin = new RoundButton();
            btnClient = new RoundButton();
            pSelectUser.SuspendLayout();
            SuspendLayout();
            // 
            // pSelectUser
            // 
            pSelectUser.BackColor = Color.FromArgb(248, 246, 239);
            pSelectUser.Controls.Add(btnAdmin);
            pSelectUser.Controls.Add(btnClient);
            pSelectUser.Location = new Point(187, 162);
            pSelectUser.Name = "pSelectUser";
            pSelectUser.Size = new Size(350, 380);
            pSelectUser.TabIndex = 0;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Lime;
            btnAdmin.Font = new Font("Segoe UI", 15F);
            btnAdmin.Location = new Point(78, 237);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(198, 62);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = " Manager";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnClient
            // 
            btnClient.BackColor = Color.Lime;
            btnClient.Font = new Font("Segoe UI", 15F);
            btnClient.Location = new Point(78, 82);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(198, 62);
            btnClient.TabIndex = 0;
            btnClient.Text = "Costumer";
            btnClient.UseVisualStyleBackColor = false;
            // 
            // frLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 239, 232);
            ClientSize = new Size(729, 689);
            Controls.Add(pSelectUser);
            Name = "frLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            Resize += Login_Resize;
            pSelectUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pSelectUser;
        private RoundButton btnClient;
        private RoundButton btnAdmin;
    }
}