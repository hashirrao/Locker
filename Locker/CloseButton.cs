using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Locker
{
    class CloseButton : PictureBox
    {
        public CloseButton()
        {
            this.Size = new Size(14, 14);
            this.BackgroundImage = Properties.Resources.CloseButton;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.CloseEnter;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.CloseButton;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.ClosePress;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.CloseEnter;
        }
    }
}
