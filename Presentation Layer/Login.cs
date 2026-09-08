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
            //Set the visibility of the panels
            pSelectUser.Visible = true;
            pRegisterClient.Visible = pRegisterAdmin.Visible = pLoginClient.Visible = pLoginAdmin.Visible = false;

            //Modify the design of the panels and buttons
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
            pLoginAdmin.Visible = true;
            pLoginClient.Visible = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pSelectUser.Visible = false;
            pLoginClient.Visible = true;
            pLoginAdmin.Visible = false;

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

                //Validate the input given by the user.
                if (Validations.IsNumber(txtDNIClient.Text) && Validations.IsString(name, lastname))
                {
                    int dni = Convert.ToInt32(txtDNIClient.Text);

                    Client client = new(dni, name, lastname, email);

                    //Return the ValidationsResult structure. If it has errors, it gives back a list with them.
                    ValidatorClient validateClient = new();
                    var result = validateClient.Validate(client);

                    if (!result.IsValid)
                    {

                        string errors = "";
                        errors = string.Join(Environment.NewLine, result.Errors);
                        if (!string.IsNullOrEmpty(errors))
                        {
                            MessageBox.Show(errors);
                            //MessageBox.Show(errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (logicClient.LInsertClient(dni, name, lastname, email))
                        {
                            MessageBox.Show("Client registered successfully.");
                            frStore store = new();
                            store.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("There was an unknown error. Try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("DNI only must have numbers.");
                }
            }
            catch (Exception error)
            {
                throw new Exception("It has ocurred an error.", error);
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
            pRegisterClient.Visible = false;
            pRegisterAdmin.Visible = true;
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            try
            {
                //Validate the input given by the user.
                if (!Validations.IsEmptyField(txtAdminDNI.Text, password) && (Validations.IsNumber(txtDNIAdmin.Text)))
                {
                    int dni = Convert.ToInt32(txtAdminDNI.Text);
                    ValidatorAdmin validateAdmin = new();
                    //Return the ValidationsResult structure. If it has errors, it gives back a list with them.
                    var result = validateAdmin.Validate(dni, password);

                    if (!result.IsValid)
                    {
                        string errors = string.Join(Environment.NewLine, result.Errors);
                        MessageBox.Show(errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Admin admin = logicAdmin.LSelectAdmin(dni, password);

                        //Verify that there's an admin registered.
                        if (admin != null)
                        {
                            //Keep the admin in a list.
                            logicAdmin.adminList.Add(admin);

                            frStore frStore = new();
                            frStore.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("DNI or Password incorrect. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    if(!Validations.IsNumber(txtAdminDNI.Text) || Validations.IsEmptyField(txtAdminDNI.Text))
                    {
                        MessageBox.Show("DNI only must have numbers.");
                        txtAdminDNI.Clear();
                        txtAdminDNI.Focus();
                    }else if (Validations.IsEmptyField(txtPassword.Text))
                    {
                        MessageBox.Show("Write a password.");
                        txtPassword.Clear();
                        txtPassword.Focus();
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
            try
            {
                //First validate the data given by the client
                if (!Validations.IsNumber(txtClientDNI.Text))
                {
                    int dni = Convert.ToInt32(txtClientDNI.Text);
                    ValidatorClient validateClient = new();
                    var result = validateClient.Validate(dni);

                    if (!result.IsValid)
                    {
                        string errors = string.Empty;
                        errors = string.Join(Environment.NewLine, result.Errors);

                        if (!string.IsNullOrEmpty(errors))
                        {
                            MessageBox.Show(errors, "DNI must contain 8 digits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        //Verify if the user it's registered
                        if (logicClient.LSelectClient(dni))
                        {
                            frStore frStore = new();

                            this.Hide();
                            frStore.Show();
                        }
                        else { MessageBox.Show("DNI incorrect"); }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Error occurred while logging in.");
            }
        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameAdmin.Text;
                string lastname = txtLastnameAdmin.Text;
                string password = txtPasswordAdmin.Text;

                if (Validations.IsNumber(txtDNIAdmin.Text) && Validations.IsString(name, lastname) && Validations.IsEmptyField(password))
                {
                    int dni = Convert.ToInt32(txtDNIClient.Text);

                    Admin admin = new(dni, name, lastname, password);
                    ValidatorAdmin validateAdmin = new();
                    var result = validateAdmin.Validate(admin);

                    if (!result.IsValid)
                    {
                        string errors = string.Join(Environment.NewLine, result.Errors);
                        MessageBox.Show(errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (logicAdmin.LInsertAdmin(dni, name, lastname, password))
                        {
                            frStore store = new();
                            store.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("There was an unknown error. Try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("DNI only must have numbers.");
                }
            }
            catch (Exception error)
            {
                throw new Exception("It has ocurred an error.", error);
            }

        }

        private void pRegisterAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
