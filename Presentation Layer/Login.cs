using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CenterPanel(Panel p)
        {
            p.Location = new Point((this.ClientSize.Width - p.Width) / 2,
            (this.ClientSize.Height - p.Height) / 2);
        }
        private void PersonalizePanel(Panel p)
        {
            //Set default background color and size of the panel
            p.BackColor = Color.FromArgb(0xF1, 0xEF, 0xE8);
            int width = Convert.ToInt32(this.Width * 0.7);
            int height = Convert.ToInt32(this.Height * 0.8);
            p.Size = new Size(width, height);

            p.BorderStyle = BorderStyle.None;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PersonalizePanel(pSelectUser);
            CenterPanel(pSelectUser);
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            //Rezise the panel when the form is resized
            int width = Convert.ToInt32(this.Width*0.7);
            int height = Convert.ToInt32(this.Height*0.8);

            if(width < 350 || height < 380)
            {
                pSelectUser.Width = 350; pSelectUser.Height = 380;
            }
            else
            {
                pSelectUser.Width = width; pSelectUser.Height = height;
            }

            //Center the panel
            CenterPanel(pSelectUser);
        }
    }
}
