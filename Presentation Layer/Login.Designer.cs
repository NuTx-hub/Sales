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
            txtCustomerDNI = new TextBox();
            btnLoginClient = new RoundButton();
            pRegisterAdmin = new Panel();
            label1 = new Label();
            panel11 = new Panel();
            textBox6 = new TextBox();
            panel10 = new Panel();
            textBox5 = new TextBox();
            btnRegisterAdminUndo = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            textBox1 = new TextBox();
            txtDNI = new TextBox();
            btnRegisterAdmin = new RoundButton();
            pRegisterClient = new Panel();
            panel14 = new Panel();
            textBox8 = new TextBox();
            panel13 = new Panel();
            textBox7 = new TextBox();
            btnRegisterClientUndo = new Button();
            panel8 = new Panel();
            panel9 = new Panel();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            // 
            // pLoginClient
            // 
            pLoginClient.BackColor = Color.FromArgb(248, 246, 239);
            pLoginClient.Controls.Add(lblRegisterClient);
            pLoginClient.Controls.Add(btnClientUndo);
            pLoginClient.Controls.Add(panel3);
            pLoginClient.Controls.Add(txtCustomerDNI);
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
            pRegisterAdmin.Location = new Point(565, 464);
            pRegisterAdmin.Name = "pRegisterAdmin";
            pRegisterAdmin.Size = new Size(305, 348);
            pRegisterAdmin.TabIndex = 4;
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
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 16F);
            textBox6.Location = new Point(58, 228);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Password";
            textBox6.Size = new Size(198, 29);
            textBox6.TabIndex = 12;
            textBox6.UseSystemPasswordChar = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Lime;
            panel10.Location = new Point(59, 207);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 3);
            panel10.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 16F);
            textBox5.Location = new Point(58, 181);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Lastname";
            textBox5.Size = new Size(198, 29);
            textBox5.TabIndex = 10;
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(58, 132);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(198, 29);
            textBox1.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.BorderStyle = BorderStyle.None;
            txtDNI.Font = new Font("Segoe UI", 16F);
            txtDNI.Location = new Point(59, 83);
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
            btnRegisterAdmin.Location = new Point(58, 278);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(198, 52);
            btnRegisterAdmin.TabIndex = 0;
            btnRegisterAdmin.Text = "Sign Up";
            btnRegisterAdmin.UseVisualStyleBackColor = false;
            // 
            // pRegisterClient
            // 
            pRegisterClient.BackColor = Color.FromArgb(248, 246, 239);
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
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI", 16F);
            textBox8.Location = new Point(52, 227);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Email";
            textBox8.Size = new Size(198, 29);
            textBox8.TabIndex = 16;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Lime;
            panel13.Location = new Point(52, 208);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 3);
            panel13.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 16F);
            textBox7.Location = new Point(52, 182);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Lastname";
            textBox7.Size = new Size(198, 29);
            textBox7.TabIndex = 10;
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
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(52, 133);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Name";
            textBox3.Size = new Size(198, 29);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 16F);
            textBox4.Location = new Point(52, 83);
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
        private TextBox txtCustomerDNI;
        private Button btnClientUndo;
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