using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Job_Application_Management
{
    public class RoudingPanel : Panel
    {
        public RoudingPanel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (var graphicsPath = new GraphicsPath())
            {
                var cornerRadius = 15;
                var rectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

                graphicsPath.AddArc(rectangle.X, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
                graphicsPath.AddArc(rectangle.X + rectangle.Width - cornerRadius * 2, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
                graphicsPath.AddArc(rectangle.X + rectangle.Width - cornerRadius * 2, rectangle.Y + rectangle.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                graphicsPath.AddArc(rectangle.X, rectangle.Y + rectangle.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                graphicsPath.CloseFigure();

                this.Region = new Region(graphicsPath);

                using (var pen = new Pen(this.BackColor, 1))
                {
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
        }
    }
}
