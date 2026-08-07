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
            pClientLogin = new Panel();
            btnAdminUndo = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtAdminDNI = new TextBox();
            btnAdminLogin = new RoundButton();
            pManagerLogin = new Panel();
            btnCustomerUndo = new Button();
            panel3 = new Panel();
            txtCustomerDNI = new TextBox();
            btnCustomerLogin = new RoundButton();
            lblRegisterAdmin = new Label();
            lblRegisterClient = new Label();
            pRegisterAdmin = new Panel();
            btnRegisterAdminUndo = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            textBox1 = new TextBox();
            txtDNI = new TextBox();
            btnRegisterAdmin = new RoundButton();
            pRegisterClient = new Panel();
            btnRegisterClientUndo = new Button();
            panel8 = new Panel();
            panel9 = new Panel();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnRegisterClient = new RoundButton();
            panel10 = new Panel();
            textBox5 = new TextBox();
            panel11 = new Panel();
            textBox6 = new TextBox();
            panel13 = new Panel();
            textBox7 = new TextBox();
            label1 = new Label();
            panel14 = new Panel();
            textBox8 = new TextBox();
            label2 = new Label();
            pSelectUser.SuspendLayout();
            pClientLogin.SuspendLayout();
            pManagerLogin.SuspendLayout();
            pRegisterAdmin.SuspendLayout();
            pRegisterClient.SuspendLayout();
            SuspendLayout();
            // 
            // pSelectUser
            // 
            pSelectUser.BackColor = Color.FromArgb(248, 246, 239);
            pSelectUser.Controls.Add(btnClient);
            pSelectUser.Controls.Add(btnAdmin);
            pSelectUser.Location = new Point(63, 70);
            pSelectUser.Name = "pSelectUser";
            pSelectUser.Size = new Size(306, 333);
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
            // pClientLogin
            // 
            pClientLogin.BackColor = Color.FromArgb(248, 246, 239);
            pClientLogin.Controls.Add(lblRegisterAdmin);
            pClientLogin.Controls.Add(btnAdminUndo);
            pClientLogin.Controls.Add(panel2);
            pClientLogin.Controls.Add(panel1);
            pClientLogin.Controls.Add(txtPassword);
            pClientLogin.Controls.Add(txtAdminDNI);
            pClientLogin.Controls.Add(btnAdminLogin);
            pClientLogin.Location = new Point(63, 431);
            pClientLogin.Name = "pClientLogin";
            pClientLogin.Size = new Size(306, 333);
            pClientLogin.TabIndex = 2;
            pClientLogin.Paint += pClientLogin_Paint;
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
            txtPassword.TextChanged += textBox1_TextChanged;
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
            txtAdminDNI.TextChanged += txtAdminCi_TextChanged;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.Lime;
            btnAdminLogin.Font = new Font("Segoe UI", 20F);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(52, 236);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(198, 62);
            btnAdminLogin.TabIndex = 0;
            btnAdminLogin.Text = "Log In";
            btnAdminLogin.UseVisualStyleBackColor = false;
            // 
            // pManagerLogin
            // 
            pManagerLogin.BackColor = Color.FromArgb(248, 246, 239);
            pManagerLogin.Controls.Add(lblRegisterClient);
            pManagerLogin.Controls.Add(btnCustomerUndo);
            pManagerLogin.Controls.Add(panel3);
            pManagerLogin.Controls.Add(txtCustomerDNI);
            pManagerLogin.Controls.Add(btnCustomerLogin);
            pManagerLogin.Location = new Point(405, 70);
            pManagerLogin.Name = "pManagerLogin";
            pManagerLogin.Size = new Size(306, 333);
            pManagerLogin.TabIndex = 3;
            pManagerLogin.Paint += pManagerLogin_Paint;
            // 
            // btnCustomerUndo
            // 
            btnCustomerUndo.BackgroundImage = (Image)resources.GetObject("btnCustomerUndo.BackgroundImage");
            btnCustomerUndo.BackgroundImageLayout = ImageLayout.Stretch;
            btnCustomerUndo.Location = new Point(18, 20);
            btnCustomerUndo.Name = "btnCustomerUndo";
            btnCustomerUndo.Size = new Size(35, 35);
            btnCustomerUndo.TabIndex = 7;
            btnCustomerUndo.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lime;
            panel3.Location = new Point(59, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 3);
            panel3.TabIndex = 6;
            // 
            // txtCustomerDNI
            // 
            txtCustomerDNI.BorderStyle = BorderStyle.None;
            txtCustomerDNI.Font = new Font("Segoe UI", 20F);
            txtCustomerDNI.ForeColor = Color.Black;
            txtCustomerDNI.Location = new Point(59, 101);
            txtCustomerDNI.Name = "txtCustomerDNI";
            txtCustomerDNI.PlaceholderText = "Type your DNI";
            txtCustomerDNI.Size = new Size(198, 36);
            txtCustomerDNI.TabIndex = 5;
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.BackColor = Color.Lime;
            btnCustomerLogin.Font = new Font("Segoe UI", 20F);
            btnCustomerLogin.ForeColor = Color.White;
            btnCustomerLogin.Location = new Point(59, 189);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new Size(198, 62);
            btnCustomerLogin.TabIndex = 0;
            btnCustomerLogin.Text = "Log In";
            btnCustomerLogin.UseVisualStyleBackColor = false;
            // 
            // lblRegisterAdmin
            // 
            lblRegisterAdmin.AutoSize = true;
            lblRegisterAdmin.Font = new Font("Segoe UI", 11F);
            lblRegisterAdmin.Location = new Point(52, 205);
            lblRegisterAdmin.Name = "lblRegisterAdmin";
            lblRegisterAdmin.Size = new Size(172, 20);
            lblRegisterAdmin.TabIndex = 9;
            lblRegisterAdmin.Text = "Not Registered? Sign Up";
            lblRegisterAdmin.Click += label1_Click;
            // 
            // lblRegisterClient
            // 
            lblRegisterClient.AutoSize = true;
            lblRegisterClient.Font = new Font("Segoe UI", 11F);
            lblRegisterClient.Location = new Point(59, 156);
            lblRegisterClient.Name = "lblRegisterClient";
            lblRegisterClient.Size = new Size(172, 20);
            lblRegisterClient.TabIndex = 10;
            lblRegisterClient.Text = "Not Registered? Sign Up";
            // 
            // pRegisterAdmin
            // 
            pRegisterAdmin.BackColor = Color.FromArgb(248, 246, 239);
            pRegisterAdmin.Controls.Add(label1);
            pRegisterAdmin.Controls.Add(panel11);
            pRegisterAdmin.Controls.Add(textBox6);
            pRegisterAdmin.Controls.Add(panel10);
            pRegisterAdmin.Controls.Add(textBox5);
            pRegisterAdmin.Controls.Add(btnRegisterAdminUndo);
            pRegisterAdmin.Controls.Add(panel5);
            pRegisterAdmin.Controls.Add(panel6);
            pRegisterAdmin.Controls.Add(textBox1);
            pRegisterAdmin.Controls.Add(txtDNI);
            pRegisterAdmin.Controls.Add(btnRegisterAdmin);
            pRegisterAdmin.Location = new Point(405, 431);
            pRegisterAdmin.Name = "pRegisterAdmin";
            pRegisterAdmin.Size = new Size(305, 395);
            pRegisterAdmin.TabIndex = 4;
            pRegisterAdmin.Paint += panel4_Paint;
            // 
            // btnRegisterAdminUndo
            // 
            btnRegisterAdminUndo.BackColor = Color.FromArgb(248, 246, 239);
            btnRegisterAdminUndo.BackgroundImage = (Image)resources.GetObject("btnRegisterAdminUndo.BackgroundImage");
            btnRegisterAdminUndo.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegisterAdminUndo.Location = new Point(22, 25);
            btnRegisterAdminUndo.Name = "btnRegisterAdminUndo";
            btnRegisterAdminUndo.Size = new Size(35, 35);
            btnRegisterAdminUndo.TabIndex = 8;
            btnRegisterAdminUndo.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lime;
            panel5.Location = new Point(55, 199);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 3);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Lime;
            panel6.Location = new Point(57, 150);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 3);
            panel6.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(54, 173);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(198, 29);
            textBox1.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.BorderStyle = BorderStyle.None;
            txtDNI.Font = new Font("Segoe UI", 16F);
            txtDNI.Location = new Point(55, 124);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "DNI";
            txtDNI.Size = new Size(198, 29);
            txtDNI.TabIndex = 4;
            // 
            // btnRegisterAdmin
            // 
            btnRegisterAdmin.BackColor = Color.Lime;
            btnRegisterAdmin.Font = new Font("Segoe UI", 20F);
            btnRegisterAdmin.ForeColor = Color.White;
            btnRegisterAdmin.Location = new Point(54, 319);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(198, 52);
            btnRegisterAdmin.TabIndex = 0;
            btnRegisterAdmin.Text = "Sign Up";
            btnRegisterAdmin.UseVisualStyleBackColor = false;
            // 
            // pRegisterClient
            // 
            pRegisterClient.BackColor = Color.FromArgb(248, 246, 239);
            pRegisterClient.Controls.Add(label2);
            pRegisterClient.Controls.Add(panel14);
            pRegisterClient.Controls.Add(textBox8);
            pRegisterClient.Controls.Add(panel13);
            pRegisterClient.Controls.Add(textBox7);
            pRegisterClient.Controls.Add(btnRegisterClientUndo);
            pRegisterClient.Controls.Add(panel8);
            pRegisterClient.Controls.Add(panel9);
            pRegisterClient.Controls.Add(textBox3);
            pRegisterClient.Controls.Add(textBox4);
            pRegisterClient.Controls.Add(btnRegisterClient);
            pRegisterClient.Location = new Point(773, 70);
            pRegisterClient.Name = "pRegisterClient";
            pRegisterClient.Size = new Size(305, 395);
            pRegisterClient.TabIndex = 5;
            // 
            // btnRegisterClientUndo
            // 
            btnRegisterClientUndo.BackColor = Color.FromArgb(248, 246, 239);
            btnRegisterClientUndo.BackgroundImage = (Image)resources.GetObject("btnRegisterClientUndo.BackgroundImage");
            btnRegisterClientUndo.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegisterClientUndo.Location = new Point(22, 25);
            btnRegisterClientUndo.Name = "btnRegisterClientUndo";
            btnRegisterClientUndo.Size = new Size(35, 35);
            btnRegisterClientUndo.TabIndex = 8;
            btnRegisterClientUndo.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Lime;
            panel8.Location = new Point(52, 199);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 3);
            panel8.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Lime;
            panel9.Location = new Point(52, 153);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 3);
            panel9.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(52, 173);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Name";
            textBox3.Size = new Size(198, 29);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 16F);
            textBox4.Location = new Point(52, 124);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "DNI";
            textBox4.Size = new Size(198, 29);
            textBox4.TabIndex = 4;
            // 
            // btnRegisterClient
            // 
            btnRegisterClient.BackColor = Color.Lime;
            btnRegisterClient.Font = new Font("Segoe UI", 20F);
            btnRegisterClient.ForeColor = Color.White;
            btnRegisterClient.Location = new Point(52, 316);
            btnRegisterClient.Name = "btnRegisterClient";
            btnRegisterClient.Size = new Size(198, 52);
            btnRegisterClient.TabIndex = 0;
            btnRegisterClient.Text = "Sign Up";
            btnRegisterClient.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Lime;
            panel10.Location = new Point(55, 248);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 3);
            panel10.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 16F);
            textBox5.Location = new Point(54, 222);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Lastname";
            textBox5.Size = new Size(198, 29);
            textBox5.TabIndex = 10;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Lime;
            panel11.Location = new Point(57, 295);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 3);
            panel11.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 16F);
            textBox6.Location = new Point(54, 269);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Password";
            textBox6.Size = new Size(198, 29);
            textBox6.TabIndex = 12;
            textBox6.UseSystemPasswordChar = true;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Lime;
            panel13.Location = new Point(52, 248);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 3);
            panel13.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 16F);
            textBox7.Location = new Point(52, 222);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Lastname";
            textBox7.Size = new Size(198, 29);
            textBox7.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(54, 63);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 13;
            label1.Text = "Register Admin";
            // 
            // panel14
            // 
            panel14.BackColor = Color.Lime;
            panel14.Location = new Point(52, 296);
            panel14.Name = "panel14";
            panel14.Size = new Size(200, 3);
            panel14.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI", 16F);
            textBox8.Location = new Point(52, 267);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Email";
            textBox8.Size = new Size(198, 29);
            textBox8.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(62, 65);
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
            ClientSize = new Size(1119, 837);
            Controls.Add(pRegisterClient);
            Controls.Add(pRegisterAdmin);
            Controls.Add(pClientLogin);
            Controls.Add(pManagerLogin);
            Controls.Add(pSelectUser);
            Name = "frLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            Resize += Login_Resize;
            pSelectUser.ResumeLayout(false);
            pClientLogin.ResumeLayout(false);
            pClientLogin.PerformLayout();
            pManagerLogin.ResumeLayout(false);
            pManagerLogin.PerformLayout();
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
        private Panel pClientLogin;
        private RoundButton btnAdminLogin;
        private Panel pManagerLogin;
        private RoundButton btnCustomerLogin;
        private TextBox txtAdminDNI;
        private TextBox txtPassword;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private TextBox txtCustomerDNI;
        private Button btnCustomerUndo;
        private Button btnAdminUndo;
        private Label lblRegisterAdmin;
        private Label lblRegisterClient;
        private Panel pRegisterAdmin;
        private Panel panel10;
        private TextBox textBox5;
        private Button btnRegisterAdminUndo;
        private Panel panel5;
        private Panel panel6;
        private TextBox textBox1;
        private TextBox txtDNI;
        private RoundButton btnRegisterAdmin;
        private Panel pRegisterClient;
        private Button btnRegisterClientUndo;
        private Panel panel8;
        private Panel panel9;
        private TextBox textBox3;
        private TextBox textBox4;
        private RoundButton btnRegisterClient;
        private Panel panel11;
        private TextBox textBox6;
        private Panel panel13;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private Panel panel14;
        private TextBox textBox8;
    }
}