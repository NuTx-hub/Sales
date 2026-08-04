using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Presentation_Layer
{

    public class RoundButton : Button
    {
        [Browsable(true)]
        [Category("Appearance")]
        [Description("The radius, in pixels, used to round the button corners.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(20)]
        public int BorderRadius { get; set; } = 20; // adjust this value

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            GraphicsPath path = RoundedRect(rect, BorderRadius);

            // Background color
            using (SolidBrush brush = new SolidBrush(BackColor))
                g.FillPath(brush, path);

            // Button text
            using (SolidBrush textBrush = new SolidBrush(ForeColor))
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(Text, Font, textBrush, rect, sf);
            }

            this.Region = new Region(path);
        }

        private GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
