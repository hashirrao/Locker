using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Locker
{
    class MaximizeButton : PictureBox
    {
        public MaximizeButton()
        {
            this.BackgroundImage = Properties.Resources.MaximizeButton;
            this.Size = new System.Drawing.Size(14, 14);
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MaximizeEnter;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MaximizeButton;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MaximizePress;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MaximizeEnter;
        }
    }
}
