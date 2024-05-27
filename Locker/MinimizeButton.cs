using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Locker
{
    class MinimizeButton : PictureBox
    {
        public MinimizeButton()
        {
            this.BackgroundImage = Properties.Resources.MinimizeButton;
            this.Size = new System.Drawing.Size(14, 14);
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MinimizeEnter;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MinimizeButton;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MinimizePress;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MinimizeEnter;
        }
    }
}
