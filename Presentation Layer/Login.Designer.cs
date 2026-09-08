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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
            pSelectUser = new Panel();
            btnClient = new RoundButton();
            btnAdmin = new RoundButton();
            pLoginAdmin = new Panel();
            lblRegisterAdmin = new Label();
            btnAdminUndo = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtAdminDNI = new TextBox();
            btnLoginAdmin = new RoundButton();
            pLoginClient = new Panel();
            lblRegisterClient = new Label();
            btnClientUndo = new Button();
            panel3 = new Panel();
            txtClientDNI = new TextBox();
            btnLoginClient = new RoundButton();
            pRegisterAdmin = new Panel();
            label1 = new Label();
            panel11 = new Panel();
            txtPasswordAdmin = new TextBox();
            panel10 = new Panel();
            txtLastnameAdmin = new TextBox();
            btnRegisterAdminUndo = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            txtNameAdmin = new TextBox();
            txtDNIAdmin = new TextBox();
            btnRegisterAdmin = new RoundButton();
            pRegisterClient = new Panel();
            panel14 = new Panel();
            txtEmail = new TextBox();
            panel13 = new Panel();
            txtLastnameClient = new TextBox();
            btnRegisterClientUndo = new Button();
            panel8 = new Panel();
            panel9 = new Panel();
            txtNameClient = new TextBox();
            txtDNIClient = new TextBox();
            btnRegisterClient = new RoundButton();
            label2 = new Label();
            pSelectUser.SuspendLayout();
            pLoginAdmin.SuspendLayout();
            pLoginClient.SuspendLayout();
            pRegisterAdmin.SuspendLayout();
            pRegisterClient.SuspendLayout();
            SuspendLayout();
            // 
            // pSelectUser
            // 
            pSelectUser.BackColor = Color.FromArgb(248, 246, 239);
            pSelectUser.Controls.Add(btnClient);
            pSelectUser.Controls.Add(btnAdmin);
            pSelectUser.Location = new Point(809, 102);
            pSelectUser.Name = "pSelectUser";
            pSelectUser.Size = new Size(305, 333);
            pSelectUser.TabIndex = 0;
            // 
            // btnClient
            // 
            btnClient.BackColor = Color.Lime;
            btnClient.Font = new Font("Segoe UI", 20F);
            btnClient.ForeColor = Color.White;
            btnClient.Location = new Point(48, 198);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(198, 62);
            btnClient.TabIndex = 0;
            btnClient.Text = "Costumer";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Lime;
            btnAdmin.Font = new Font("Segoe UI", 20F);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(48, 65);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(198, 62);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = " Manager";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pLoginAdmin
            // 
            pLoginAdmin.BackColor = Color.FromArgb(248, 246, 239);
            pLoginAdmin.Controls.Add(lblRegisterAdmin);
            pLoginAdmin.Controls.Add(btnAdminUndo);
            pLoginAdmin.Controls.Add(panel2);
            pLoginAdmin.Controls.Add(panel1);
            pLoginAdmin.Controls.Add(txtPassword);
            pLoginAdmin.Controls.Add(txtAdminDNI);
            pLoginAdmin.Controls.Add(btnLoginAdmin);
            pLoginAdmin.Location = new Point(88, 64);
            pLoginAdmin.Name = "pLoginAdmin";
            pLoginAdmin.Size = new Size(305, 333);
            pLoginAdmin.TabIndex = 2;
            // 
            // lblRegisterAdmin
            // 
            lblRegisterAdmin.AutoSize = true;
            lblRegisterAdmin.Cursor = Cursors.Hand;
            lblRegisterAdmin.Font = new Font("Segoe UI", 11F);
            lblRegisterAdmin.Location = new Point(52, 205);
            lblRegisterAdmin.Name = "lblRegisterAdmin";
            lblRegisterAdmin.Size = new Size(172, 20);
            lblRegisterAdmin.TabIndex = 9;
            lblRegisterAdmin.Text = "Not Registered? Sign Up";
            lblRegisterAdmin.Click += lblRegisterAdmin_Click;
            // 
            // btnAdminUndo
            // 
            btnAdminUndo.BackColor = Color.FromArgb(248, 246, 239);
            btnAdminUndo.BackgroundImage = (Image)resources.GetObject("btnAdminUndo.BackgroundImage");
            btnAdminUndo.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdminUndo.Location = new Point(22, 25);
            btnAdminUndo.Name = "btnAdminUndo";
            btnAdminUndo.Size = new Size(35, 35);
            btnAdminUndo.TabIndex = 8;
            btnAdminUndo.UseVisualStyleBackColor = false;
            btnAdminUndo.Click += btnAdminUndo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Location = new Point(52, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 3);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Location = new Point(52, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 3);
            panel1.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 20F);
            txtPassword.Location = new Point(52, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(198, 36);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtAdminDNI
            // 
            txtAdminDNI.BorderStyle = BorderStyle.None;
            txtAdminDNI.Font = new Font("Segoe UI", 20F);
            txtAdminDNI.Location = new Point(52, 91);
            txtAdminDNI.Name = "txtAdminDNI";
            txtAdminDNI.PlaceholderText = "Type your DNI";
            txtAdminDNI.Size = new Size(198, 36);
            txtAdminDNI.TabIndex = 4;
            txtAdminDNI.KeyPress += txtAdminDNI_KeyPress;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackColor = Color.Lime;
            btnLoginAdmin.Font = new Font("Segoe UI", 20F);
            btnLoginAdmin.ForeColor = Color.White;
            btnLoginAdmin.Location = new Point(52, 236);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(198, 62);
            btnLoginAdmin.TabIndex = 0;
            btnLoginAdmin.Text = "Log In";
            btnLoginAdmin.UseVisualStyleBackColor = false;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // pLoginClient
            // 
            pLoginClient.BackColor = Color.FromArgb(248, 246, 239);
            pLoginClient.Controls.Add(lblRegisterClient);
            pLoginClient.Controls.Add(btnClientUndo);
            pLoginClient.Controls.Add(panel3);
            pLoginClient.Controls.Add(txtClientDNI);
            pLoginClient.Controls.Add(btnLoginClient);
            pLoginClient.Location = new Point(466, 89);
            pLoginClient.Name = "pLoginClient";
            pLoginClient.Size = new Size(305, 333);
            pLoginClient.TabIndex = 3;
            // 
            // lblRegisterClient
            // 
            lblRegisterClient.AutoSize = true;
            lblRegisterClient.Cursor = Cursors.Hand;
            lblRegisterClient.Font = new Font("Segoe UI", 11F);
            lblRegisterClient.Location = new Point(59, 156);
            lblRegisterClient.Name = "lblRegisterClient";
            lblRegisterClient.Size = new Size(172, 20);
            lblRegisterClient.TabIndex = 10;
            lblRegisterClient.Text = "Not Registered? Sign Up";
            lblRegisterClient.Click += lblRegisterClient_Click;
            // 
            // btnClientUndo
            // 
            btnClientUndo.BackgroundImage = (Image)resources.GetObject("btnClientUndo.BackgroundImage");
            btnClientUndo.BackgroundImageLayout = ImageLayout.Stretch;
            btnClientUndo.Location = new Point(18, 20);
            btnClientUndo.Name = "btnClientUndo";
            btnClientUndo.Size = new Size(35, 35);
            btnClientUndo.TabIndex = 7;
            btnClientUndo.UseVisualStyleBackColor = false;
            btnClientUndo.Click += btnClientUndo_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lime;
            panel3.Location = new Point(59, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 3);
            panel3.TabIndex = 6;
            // 
            // txtClientDNI
            // 
            txtClientDNI.BorderStyle = BorderStyle.None;
            txtClientDNI.Font = new Font("Segoe UI", 20F);
            txtClientDNI.ForeColor = Color.Black;
            txtClientDNI.Location = new Point(59, 101);
            txtClientDNI.Name = "txtClientDNI";
            txtClientDNI.PlaceholderText = "Type your DNI";
            txtClientDNI.Size = new Size(198, 36);
            txtClientDNI.TabIndex = 5;
            // 
            // btnLoginClient
            // 
            btnLoginClient.BackColor = Color.Lime;
            btnLoginClient.Font = new Font("Segoe UI", 20F);
            btnLoginClient.ForeColor = Color.White;
            btnLoginClient.Location = new Point(59, 189);
            btnLoginClient.Name = "btnLoginClient";
            btnLoginClient.Size = new Size(198, 62);
            btnLoginClient.TabIndex = 0;
            btnLoginClient.Text = "Log In";
            btnLoginClient.UseVisualStyleBackColor = false;
            btnLoginClient.Click += btnLoginClient_Click;
            // 
            // pRegisterAdmin
            // 
            pRegisterAdmin.BackColor = Color.FromArgb(248, 246, 239);
            pRegisterAdmin.Controls.Add(label1);
            pRegisterAdmin.Controls.Add(panel11);
            pRegisterAdmin.Controls.Add(txtPasswordAdmin);
            pRegisterAdmin.Controls.Add(panel10);
            pRegisterAdmin.Controls.Add(txtLastnameAdmin);
            pRegisterAdmin.Controls.Add(btnRegisterAdminUndo);
            pRegisterAdmin.Controls.Add(panel5);
            pRegisterAdmin.Controls.Add(panel6);
            pRegisterAdmin.Controls.Add(txtNameAdmin);
            pRegisterAdmin.Controls.Add(txtDNIAdmin);
            pRegisterAdmin.Controls.Add(btnRegisterAdmin);
            pRegisterAdmin.Location = new Point(565, 464);
            pRegisterAdmin.Name = "pRegisterAdmin";
            pRegisterAdmin.Size = new Size(305, 348);
            pRegisterAdmin.TabIndex = 4;
            pRegisterAdmin.Paint += pRegisterAdmin_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(58, 22);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 13;
            label1.Text = "Register Admin";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Lime;
            panel11.Location = new Point(61, 254);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 3);
            panel11.TabIndex = 11;
            // 
            // txtPasswordAdmin
            // 
            txtPasswordAdmin.BorderStyle = BorderStyle.None;
            txtPasswordAdmin.Font = new Font("Segoe UI", 16F);
            txtPasswordAdmin.Location = new Point(58, 228);
            txtPasswordAdmin.Name = "txtPasswordAdmin";
            txtPasswordAdmin.PlaceholderText = "Password";
            txtPasswordAdmin.Size = new Size(198, 29);
            txtPasswordAdmin.TabIndex = 12;
            txtPasswordAdmin.UseSystemPasswordChar = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Lime;
            panel10.Location = new Point(59, 207);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 3);
            panel10.TabIndex = 9;
            // 
            // txtLastnameAdmin
            // 
            txtLastnameAdmin.BorderStyle = BorderStyle.None;
            txtLastnameAdmin.Font = new Font("Segoe UI", 16F);
            txtLastnameAdmin.Location = new Point(58, 181);
            txtLastnameAdmin.Name = "txtLastnameAdmin";
            txtLastnameAdmin.PlaceholderText = "Lastname";
            txtLastnameAdmin.Size = new Size(198, 29);
            txtLastnameAdmin.TabIndex = 10;
            // 
            // btnRegisterAdminUndo
            // 
            btnRegisterAdminUndo.BackColor = Color.FromArgb(248, 246, 239);
            btnRegisterAdminUndo.BackgroundImage = (Image)resources.GetObject("btnRegisterAdminUndo.BackgroundImage");
            btnRegisterAdminUndo.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegisterAdminUndo.Location = new Point(5, 22);
            btnRegisterAdminUndo.Name = "btnRegisterAdminUndo";
            btnRegisterAdminUndo.Size = new Size(35, 35);
            btnRegisterAdminUndo.TabIndex = 8;
            btnRegisterAdminUndo.UseVisualStyleBackColor = false;
            btnRegisterAdminUndo.Click += btnRegisterAdminUndo_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lime;
            panel5.Location = new Point(59, 158);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 3);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Lime;
            panel6.Location = new Point(61, 109);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 3);
            panel6.TabIndex = 4;
            // 
            // txtNameAdmin
            // 
            txtNameAdmin.BorderStyle = BorderStyle.None;
            txtNameAdmin.Font = new Font("Segoe UI", 16F);
            txtNameAdmin.Location = new Point(58, 132);
            txtNameAdmin.Name = "txtNameAdmin";
            txtNameAdmin.PlaceholderText = "Name";
            txtNameAdmin.Size = new Size(198, 29);
            txtNameAdmin.TabIndex = 5;
            // 
            // txtDNIAdmin
            // 
            txtDNIAdmin.BorderStyle = BorderStyle.None;
            txtDNIAdmin.Font = new Font("Segoe UI", 16F);
            txtDNIAdmin.Location = new Point(59, 83);
            txtDNIAdmin.Name = "txtDNIAdmin";
            txtDNIAdmin.PlaceholderText = "DNI";
            txtDNIAdmin.Size = new Size(198, 29);
            txtDNIAdmin.TabIndex = 4;
            // 
            // btnRegisterAdmin
            // 
            btnRegisterAdmin.BackColor = Color.Lime;
            btnRegisterAdmin.Font = new Font("Segoe UI", 20F);
            btnRegisterAdmin.ForeColor = Color.White;
            btnRegisterAdmin.Location = new Point(58, 278);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(198, 52);
            btnRegisterAdmin.TabIndex = 0;
            btnRegisterAdmin.Text = "Sign Up";
            btnRegisterAdmin.UseVisualStyleBackColor = false;
            btnRegisterAdmin.Click += btnRegisterAdmin_Click;
            // 
            // pRegisterClient
            // 
            pRegisterClient.BackColor = Color.FromArgb(248, 246, 239);
            pRegisterClient.Controls.Add(panel14);
            pRegisterClient.Controls.Add(txtEmail);
            pRegisterClient.Controls.Add(panel13);
            pRegisterClient.Controls.Add(txtLastnameClient);
            pRegisterClient.Controls.Add(btnRegisterClientUndo);
            pRegisterClient.Controls.Add(panel8);
            pRegisterClient.Controls.Add(panel9);
            pRegisterClient.Controls.Add(txtNameClient);
            pRegisterClient.Controls.Add(txtDNIClient);
            pRegisterClient.Controls.Add(btnRegisterClient);
            pRegisterClient.Controls.Add(label2);
            pRegisterClient.Location = new Point(214, 464);
            pRegisterClient.Name = "pRegisterClient";
            pRegisterClient.Size = new Size(305, 348);
            pRegisterClient.TabIndex = 5;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Lime;
            panel14.Location = new Point(52, 256);
            panel14.Name = "panel14";
            panel14.Size = new Size(200, 3);
            panel14.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 16F);
            txtEmail.Location = new Point(52, 227);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(198, 29);
            txtEmail.TabIndex = 16;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Lime;
            panel13.Location = new Point(52, 208);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 3);
            panel13.TabIndex = 9;
            // 
            // txtLastnameClient
            // 
            txtLastnameClient.BorderStyle = BorderStyle.None;
            txtLastnameClient.Font = new Font("Segoe UI", 16F);
            txtLastnameClient.Location = new Point(52, 182);
            txtLastnameClient.Name = "txtLastnameClient";
            txtLastnameClient.PlaceholderText = "Lastname";
            txtLastnameClient.Size = new Size(198, 29);
            txtLastnameClient.TabIndex = 10;
            // 
            // btnRegisterClientUndo
            // 
            btnRegisterClientUndo.BackColor = Color.FromArgb(248, 246, 239);
            btnRegisterClientUndo.BackgroundImage = (Image)resources.GetObject("btnRegisterClientUndo.BackgroundImage");
            btnRegisterClientUndo.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegisterClientUndo.Location = new Point(3, 25);
            btnRegisterClientUndo.Name = "btnRegisterClientUndo";
            btnRegisterClientUndo.Size = new Size(35, 35);
            btnRegisterClientUndo.TabIndex = 8;
            btnRegisterClientUndo.UseVisualStyleBackColor = false;
            btnRegisterClientUndo.Click += btnRegisterClientUndo_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Lime;
            panel8.Location = new Point(52, 159);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 3);
            panel8.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Lime;
            panel9.Location = new Point(52, 112);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 3);
            panel9.TabIndex = 4;
            // 
            // txtNameClient
            // 
            txtNameClient.BorderStyle = BorderStyle.None;
            txtNameClient.Font = new Font("Segoe UI", 16F);
            txtNameClient.Location = new Point(52, 133);
            txtNameClient.Name = "txtNameClient";
            txtNameClient.PlaceholderText = "Name";
            txtNameClient.Size = new Size(198, 29);
            txtNameClient.TabIndex = 5;
            // 
            // txtDNIClient
            // 
            txtDNIClient.BorderStyle = BorderStyle.None;
            txtDNIClient.Font = new Font("Segoe UI", 16F);
            txtDNIClient.Location = new Point(52, 83);
            txtDNIClient.Name = "txtDNIClient";
            txtDNIClient.PlaceholderText = "DNI";
            txtDNIClient.Size = new Size(198, 29);
            txtDNIClient.TabIndex = 4;
            // 
            // btnRegisterClient
            // 
            btnRegisterClient.BackColor = Color.Lime;
            btnRegisterClient.Font = new Font("Segoe UI", 20F);
            btnRegisterClient.ForeColor = Color.White;
            btnRegisterClient.Location = new Point(52, 276);
            btnRegisterClient.Name = "btnRegisterClient";
            btnRegisterClient.Size = new Size(198, 52);
            btnRegisterClient.TabIndex = 0;
            btnRegisterClient.Text = "Sign Up";
            btnRegisterClient.UseVisualStyleBackColor = false;
            btnRegisterClient.Click += btnRegisterClient_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(62, 25);
            label2.Name = "label2";
            label2.Size = new Size(188, 37);
            label2.TabIndex = 17;
            label2.Text = "Register Client";
            // 
            // frLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 239, 232);
            ClientSize = new Size(1272, 824);
            Controls.Add(pSelectUser);
            Controls.Add(pLoginClient);
            Controls.Add(pRegisterAdmin);
            Controls.Add(pRegisterClient);
            Controls.Add(pLoginAdmin);
            Name = "frLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            Resize += Login_Resize;
            pSelectUser.ResumeLayout(false);
            pLoginAdmin.ResumeLayout(false);
            pLoginAdmin.PerformLayout();
            pLoginClient.ResumeLayout(false);
            pLoginClient.PerformLayout();
            pRegisterAdmin.ResumeLayout(false);
            pRegisterAdmin.PerformLayout();
            pRegisterClient.ResumeLayout(false);
            pRegisterClient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSelectUser;
        private RoundButton btnClient;
        private RoundButton btnAdmin;
        private Panel pLoginAdmin;
        private RoundButton btnLoginAdmin;
        private Panel pLoginClient;
        private RoundButton btnLoginClient;
        private TextBox txtAdminDNI;
        private TextBox txtPassword;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private TextBox txtClientDNI;
        private Button btnClientUndo;
        private Button btnAdminUndo;
        private Label lblRegisterAdmin;
        private Label lblRegisterClient;
        private Panel pRegisterAdmin;
        private Panel panel10;
        private TextBox txtLastnameAdmin;
        private Button btnRegisterAdminUndo;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtNameAdmin;
        private TextBox txtDNIAdmin;
        private RoundButton btnRegisterAdmin;
        private Panel pRegisterClient;
        private Button btnRegisterClientUndo;
        private Panel panel8;
        private Panel panel9;
        private TextBox txtNameClient;
        private TextBox txtDNIClient;
        private RoundButton btnRegisterClient;
        private Panel panel11;
        private TextBox txtPasswordAdmin;
        private Panel panel13;
        private TextBox txtLastnameClient;
        private Label label1;
        private Label label2;
        private Panel panel14;
        private TextBox txtEmail;
    }
}