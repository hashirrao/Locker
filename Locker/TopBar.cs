using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locker
{
    class TopBar : PictureBox
    {
        public TopBar()
        {
            this.Height = 20;
            this.Width = 480;
            this.BackgroundImage = Properties.Resources.LockerTopBar;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
