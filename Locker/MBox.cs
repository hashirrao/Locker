using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locker
{
    public partial class MBox : Form
    {
        private int x, y;
        private bool move, result = false;
        
        public MBox()
        {
            InitializeComponent();
        }

        public MBox(string s)
        {
            InitializeComponent();
            yesButton.Visible = false;
            noButton.Visible = false;
            okButton.Visible = true;
            label.Text = s;
            if (label.Width > 400 || label.Height > 15)
            {
                this.Width = label.Width + 20;
                this.Height = label.Height + 72 + 30;
            }
            else
            {
                this.Size = new Size(400, 150);
            }
            
        }

        public MBox(string m, string conf)
        {
            InitializeComponent();
            label.Text = m;
            if (label.Width > 400 || label.Height > 15)
            {
                this.Width = label.Width + 20;
                this.Height = label.Height + 72 + 30;
            }
            else
            {
                this.Size = new Size(400, 150);
            }
            if(conf == "Simple Message")
            {
                yesButton.Visible = false;
                noButton.Visible = false;
                okButton.Visible = false;
                this.ShowInTaskbar = false;
                this.TopMost = false;
            }
            else
            {
                okButton.Visible = false;
                yesButton.Visible = true;
                noButton.Visible = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            move = true;
        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void MBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void okButton_MouseDown(object sender, MouseEventArgs e)
        {
            okButton.Size = new Size(okButton.Width - 3, okButton.Height - 3);
        }

        private void okButton_MouseUp(object sender, MouseEventArgs e)
        {
            okButton.Size = new Size(okButton.Width + 3, okButton.Height + 3);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
