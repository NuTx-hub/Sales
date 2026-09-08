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
            AttachDigitOnlyRestriction(txtAdminDNI, txtClientDNI, txtDNIClient, txtDNIAdmin);
        }
        LogicAdmin logicAdmin = new();
        LogicClient logicClient = new();

        // --------------------- FUNCTIONS --------------------- // 

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

        // Blocks any non-digit key press (except control keys like Backspace) on the given textboxes,
        // so the user physically cannot type letters/symbols into a DNI field.
        private static void AttachDigitOnlyRestriction(params TextBox[] textBoxes)
        {
            foreach (TextBox txt in textBoxes)
            {
                txt.KeyPress += (sender, e) =>
                {
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                };
            }
        }

        // Centralized, precise validation for a DNI field.
        // Returns true and outputs the parsed value only if the field is non-empty and a valid number.
        private static bool TryValidateDni(TextBox txtDni, out int dni)
        {
            dni = 0;
            string text = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter the DNI.", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return false;
            }

            if (!int.TryParse(text, out dni))
            {
                MessageBox.Show("DNI must contain numbers only.", "Invalid DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Clear();
                txtDni.Focus();
                return false;
            }

            return true;
        }

        // Precise, per-field validation for name/lastname text fields.
        private static bool TryValidateName(TextBox txtField, string fieldLabel, out string value)
        {
            value = txtField.Text.Trim();

            if (Validations.IsEmptyField(value))
            {
                MessageBox.Show($"Please enter the {fieldLabel}.", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtField.Focus();
                return false;
            }

            if (!Validations.IsString(value))
            {
                MessageBox.Show($"{fieldLabel} must contain letters only.", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtField.Clear();
                txtField.Focus();
                return false;
            }

            return true;
        }

        // --------------------- EVENTS --------------------- //


        // --------------------- LOG IN --------------------- //

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtPassword.Text.Trim();

                if (!TryValidateDni(txtAdminDNI, out int dni))
                {
                    return;
                }

                if (Validations.IsEmptyField(password))
                {
                    MessageBox.Show("Please enter the password.", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                ValidatorAdmin validateAdmin = new();
                var result = validateAdmin.Validate(dni, password);

                if (!result.IsValid)
                {
                    string errors = string.Join(Environment.NewLine, result.Errors);
                    MessageBox.Show(errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CurrentAdminSession.LogIn(dni, password))
                {
                    frStore frStore = new();
                    frStore.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("DNI or password incorrect. Try again.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                throw new Exception("Error occurred while logging in.", err);
            }
        }

        private void btnLoginClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryValidateDni(txtClientDNI, out int dni))
                {
                    return;
                }

                ValidatorClient validateClient = new();
                var result = validateClient.Validate(dni);

                if (!result.IsValid)
                {
                    string errors = string.Join(Environment.NewLine, result.Errors);
                    if (!string.IsNullOrEmpty(errors))
                    {
                        MessageBox.Show(errors, "DNI must contain 8 digits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClientDNI.Clear();
                        txtClientDNI.Focus();
                    }
                    return;
                }

                if (CurrentClientSession.LogIn(dni))
                {
                    frStore frStore = new();
                    frStore.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("DNI not found.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClientDNI.Clear();
                    txtClientDNI.Focus();
                }
            }
            catch (Exception err)
            {
                throw new Exception("Error occurred while logging in.", err);
            }
        }

        // --------------------- SIGN UP --------------------- //

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryValidateDni(txtDNIClient, out int dni)) return;
                if (!TryValidateName(txtNameClient, "name", out string name)) return;
                if (!TryValidateName(txtLastnameClient, "lastname", out string lastname)) return;

                string email = txtEmail.Text.Trim();
                if (Validations.IsEmptyField(email))
                {
                    MessageBox.Show("Please enter an email.", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                Client client = new(dni, name, lastname, email);

                ValidatorClient validateClient = new();
                var result = validateClient.Validate(client);

                if (!result.IsValid)
                {
                    string errors = string.Join(Environment.NewLine, result.Errors);
                    if (!string.IsNullOrEmpty(errors))
                    {
                        MessageBox.Show(errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                if (logicClient.IsDNIClient(dni))
                {
                    MessageBox.Show("DNI already registered.", "Duplicate DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDNIClient.Clear();
                    txtDNIClient.Focus();
                    return;
                }

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
            catch (Exception error)
            {
                throw new Exception("An error has occurred.", error);
            }
        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the input fields.
                if (!TryValidateDni(txtDNIAdmin, out int dni)) return;
                if (!TryValidateName(txtNameAdmin, "name", out string name)) return;
                if (!TryValidateName(txtLastnameAdmin, "lastname", out string lastname)) return;

                string password = txtPasswordAdmin.Text.Trim();
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password.", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPasswordAdmin.Focus();
                    return;
                }


                //Validate format of the input fields using ValidatorAdmin class.
                Admin admin = new(dni, name, lastname, password);
                ValidatorAdmin validateAdmin = new();
                var result = validateAdmin.Validate(admin);

                if (!result.IsValid)
                {
                    string errors = string.Join(Environment.NewLine, result.Errors);
                    if (!string.IsNullOrEmpty(errors))
                    {
                        MessageBox.Show(errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }

                if (logicAdmin.IsDNIAdmin(dni))
                {
                    MessageBox.Show("DNI already registered.", "Duplicate DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDNIAdmin.Clear();
                    txtDNIAdmin.Focus();
                    return;
                }

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
            catch (Exception error)
            {
                throw new Exception("An error has occurred.", error);
            }

        }

        // --------------------------------------------------- //

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
            pLoginClient.Visible = false;
            pLoginAdmin.Visible = true;
            this.AcceptButton = btnLoginAdmin; // Set the AcceptButton to btnLoginAdmin
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            pSelectUser.Visible = false;
            pLoginAdmin.Visible = false;
            pLoginClient.Visible = true;
            this.AcceptButton = btnLoginClient; // Set the AcceptButton to btnLoginClient
        }

        private void btnAdminUndo_Click(object sender, EventArgs e)
        {
            pLoginAdmin.Visible = false;
            pSelectUser.Visible = true;
            this.AcceptButton = null; // Clear the AcceptButton
        }

        private void btnRegisterClientUndo_Click(object sender, EventArgs e)
        {
            pRegisterClient.Visible = false;
            pLoginClient.Visible = true;
            this.AcceptButton = btnLoginClient; // Set the AcceptButton to btnLoginClient
        }

        private void btnRegisterAdminUndo_Click(object sender, EventArgs e)
        {
            pRegisterAdmin.Visible = false;
            pLoginAdmin.Visible = true;
            this.AcceptButton = btnLoginAdmin; // Set the AcceptButton to btnLoginAdmin
        }

        private void btnClientUndo_Click(object sender, EventArgs e)
        {
            pLoginClient.Visible = false;
            pSelectUser.Visible = true;
            this.AcceptButton = null; // Clear the AcceptButton
        }

        private void lblRegisterClient_Click(object sender, EventArgs e)
        {
            pLoginClient.Visible = false;
            txtClientDNI.Clear();
            pRegisterClient.Visible = true;
            this.AcceptButton = btnRegisterClient;

        }

        private void lblRegisterAdmin_Click(object sender, EventArgs e)
        {
            pLoginAdmin.Visible = false;
            pRegisterClient.Visible = false;
            pRegisterAdmin.Visible = true;
            this.AcceptButton = btnRegisterAdmin;
        }
    }
}