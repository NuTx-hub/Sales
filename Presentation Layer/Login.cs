using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private void CenterButtons()
        {
            //Center horizontally
            btnAdmin.Left = (pSelectUser.ClientSize.Width - btnAdmin.Width) / 2;
            btnClient.Left = (pSelectUser.ClientSize.Width - btnClient.Width) / 2;

            //Center vertically
            int spacing = 50;
            int totalHeight = btnAdmin.Height + btnClient.Height + spacing;
            int startY = (pSelectUser.ClientSize.Height - totalHeight) / 2;

            btnClient.Top = startY;
            btnAdmin.Top = startY + spacing + btnAdmin.Height;
        }

        private void ModifyPanel()
        {
            //Design panel
            PersonalizePanel();
            CenterButtons();
            CenterPanel();
        }

        //Centers any control into another one. 
        public void CenterPanel()
        {
            pSelectUser.Left = (this.ClientSize.Width - pSelectUser.Width) / 2;
            pSelectUser.Top = (this.ClientSize.Height - pSelectUser.Height) / 2;
        }

        private void PersonalizePanel()
        {
            //Set default background color and size of the panel
            pSelectUser.BackColor = Color.FromArgb(248, 246, 239);
            int width = Convert.ToInt32(this.Width * 0.7);
            int height = Convert.ToInt32(this.Height * 0.8);
            pSelectUser.Size = new Size(width, height);

            pSelectUser.BorderStyle = BorderStyle.None;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ModifyPanel();
            btnCustomerUndo.FlatStyle = FlatStyle.Flat;
            btnCustomerUndo.FlatAppearance.BorderSize = 0;
            btnAdminUndo.FlatStyle = FlatStyle.Flat;
            btnAdminUndo.FlatAppearance.BorderSize = 0;
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            //Rezise the panel when the form is resized
            int width = Convert.ToInt32(this.Width * 0.7);
            int height = Convert.ToInt32(this.Height * 0.8);

            if (width < 250 || height < 280)
            {
                pSelectUser.Width = 250; pSelectUser.Height = 280;
            }
            else
            {
                pSelectUser.Width = width; pSelectUser.Height = height;
            }

            //Center the panel
            ModifyPanel();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pSelectUser.Visible = false;
            pClientLogin.Visible = false;
            pManagerLogin.Visible = true;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pSelectUser.Visible = false;
            pManagerLogin.Visible = false;
            pClientLogin.Visible = true;

        }

        private void txtAdminCi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pClientLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pManagerLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
