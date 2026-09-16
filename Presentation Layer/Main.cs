using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entity_Layer;
using Logic_Layer;

namespace Presentation_Layer
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
            ShowLogin();
        }

        private void ShowLogin()
        {
            pnlContent.Controls.Clear();

            var login = new ucLogin { Dock = DockStyle.Fill };
            // Execute the Login_LoginSucceeded event when the Login button is clicked.
            // In other words, subscribe to the LoginSucceeded event of the ucLogin control.
            login.LoginSucceeded += Login_LoginSucceeded;

            pnlContent.Controls.Add(login);
        }

        private void Login_LoginSucceeded(object sender, EventArgs e)
        {
            // Unsubscribe from the LoginSucceeded event to avoid multiple subscriptions.
            ((ucLogin)sender).LoginSucceeded -= Login_LoginSucceeded;

            if (CurrentClientSession.CurrentClient != null)
                ShowClientView();
            else
                ShowAdminView();
        }

        private void ShowClientView()
        {
            // Clear the content panel and show the client view.
            pnlContent.Controls.Clear();
            var view = new ucClientView { Dock = DockStyle.Fill };
            pnlContent.Controls.Add(view);
        }

        private void ShowAdminView()
        {
            // Clear the content panel and show the admin view.
            pnlContent.Controls.Clear();
            var view = new ucAdminView { Dock = DockStyle.Fill };
            pnlContent.Controls.Add(view);
        }

        private void frMain_Load(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
