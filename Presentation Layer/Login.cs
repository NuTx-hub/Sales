using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void CenterPanel(Panel p)
        {
            p.Location = new Point((this.ClientSize.Width - p.Width) / 2,
            (this.ClientSize.Height - p.Height) / 2);
        }

        private void CenterButtons(params Button [] btn) // NOT FINISHED YET
        {
            //Centers all buttons in the panel. Only the x coordinate
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Location = new Point(btn[i].Left + Math.Abs(pSelectUser.Left - btn[i].Left));
                if(i >= 1)
                

            }
        }
        private void PersonalizePanel(Panel p)
        {
            //Set default background color and size of the panel
            p.BackColor = Color.FromArgb(248, 246, 239);
            int width = Convert.ToInt32(this.Width * 0.7);
            int height = Convert.ToInt32(this.Height * 0.8);
            p.Size = new Size(width, height);

            p.BorderStyle = BorderStyle.None;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PersonalizePanel(pSelectUser);
            CenterPanel(pSelectUser);
            CenterButtons(btnAdmin, btnClient);
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
            CenterButtons(btnAdmin, btnClient);
        }
    }
}
