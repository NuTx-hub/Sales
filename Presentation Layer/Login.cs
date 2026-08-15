using Entity_Layer;
using Logic_Layer;
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
        LogicAdmin logicAdmin = new();
        LogicClient logicClient = new();

        private bool ValidateClient(params object[] args)
        {
            
        }

        private static void StyleLabels(params Label[] lblList)
        {
            foreach (Label lbl in lblList)
            {
                lbl.Cursor = Cursors.Hand;
            }
        }
        private static void StyleButtons(params Button[] btnList)
        {
            foreach (Button btn in btnList)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
        }
        private void LoadPanels()
        {
            pSelectUser.Visible = true;
            pRegisterClient.Visible = pRegisterAdmin.Visible = pLoginClient.Visible = pLoginAdmin.Visible = false;
            ModifyPanel();
            StyleLabels(lblRegisterAdmin, lblRegisterClient);
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
            StylePanel(pSelectUser, pLoginAdmin, pLoginClient, pRegisterAdmin, pRegisterClient);
            CenterButtons();
            StyleButtons(btnLoginAdmin, btnRegisterAdmin, btnAdmin, btnClient, btnLoginClient, btnRegisterClient, btnClientUndo, btnAdminUndo);
            CenterPanel(pSelectUser, pLoginAdmin, pLoginClient, pRegisterAdmin, pRegisterClient);
        }

        //Centers the panels
        public void CenterPanel(params Panel[] p)
        {

            foreach (Panel pl in p)
            {
                pl.Left = (this.ClientSize.Width - pSelectUser.Width) / 2;
                pl.Top = (this.ClientSize.Height - pSelectUser.Height) / 2;
            }
        }

        private void StylePanel(params Panel[] p)
        {
            //Set default background color and size of the panel
            foreach (Panel pl in p)
            {
                pl.BackColor = Color.FromArgb(248, 246, 239);
                int width = Convert.ToInt32(this.Width * 0.7);
                int height = Convert.ToInt32(this.Height * 0.8);
                pl.Size = new Size(width, height);
                pl.BorderStyle = BorderStyle.None;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(430, 435);
            LoadPanels();

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
            pLoginAdmin.Visible = false;
            pLoginClient.Visible = true;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pSelectUser.Visible = false;
            pLoginClient.Visible = false;
            pLoginAdmin.Visible = true;

        }

        private void btnAdminUndo_Click(object sender, EventArgs e)
        {
            pLoginAdmin.Visible = false;
            pSelectUser.Visible = true;
        }

        private void btnRegisterClientUndo_Click(object sender, EventArgs e)
        {
            pRegisterClient.Visible = false;
            pLoginClient.Visible = true;
        }

        private void btnRegisterAdminUndo_Click(object sender, EventArgs e)
        {
            pRegisterAdmin.Visible = false;
            pLoginAdmin.Visible = true;
        }

        private void btnClientUndo_Click(object sender, EventArgs e)
        {
            pLoginClient.Visible = false;
            pSelectUser.Visible = true;
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameClient.Text;
                string lastname = txtLastnameClient.Text;
                string email = txtEmail.Text;
                int dni = Convert.ToInt32(txtDNIClient.Text);

                if()

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lblRegisterClient_Click(object sender, EventArgs e)
        {
            pLoginClient.Visible = false;
            pRegisterClient.Visible = true;
        }

        private void lblRegisterAdmin_Click(object sender, EventArgs e)
        {
            pLoginAdmin.Visible = false;
            pRegisterAdmin.Visible = true;
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            int DNI = Convert.ToInt32(txtAdminDNI.Text);
            string password = txtPassword.Text;

            try
            {
                //Validate the input given by the user.
                if (Validations.IsEmptyField(txtAdminDNI.Text, password) && (Validations.IsValidDNI(DNI)))
                {
                    Admin admin = logicAdmin.LSelectAdmin(DNI, password);

                    //Verify that there's an admin registered.
                    if (admin != null)
                    {
                        //Keep the admin info into the List
                        logicAdmin.adminList.Add(admin);

                        this.Hide();
                        frStore frStore = new();
                        frStore.Show();
                    }
                    else
                    {
                        MessageBox.Show("DNI or password is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {
                throw new Exception("Error occurred while logging in.");
            }
        }

        private void txtAdminDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnLoginClient_Click(object sender, EventArgs e)
        {
            int DNI = Convert.ToInt32(txtClientDNI.Text);

            try
            {
                //First validate the data given by the client
                if (!Validations.IsEmptyField(txtClientDNI.Text) && (Validations.IsValidDNI(DNI)))
                {
                    Client client = logicClient.LSelectClient(DNI);

                    //Verify if the user it's registered
                    if (client != null)
                    {
                        //Keep the client info into the List
                        logicClient.clientList.Add(client);

                        this.Hide();
                        frStore frStore = new();
                        frStore.Show();
                    }
                    else
                    {
                        MessageBox.Show("DNI or password is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {
                throw new Exception("Error occurred while logging in.");
            }
        }
    }
}
