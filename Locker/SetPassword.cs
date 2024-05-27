using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Locker
{
    public partial class SetPassword : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.MDBConnectionString);
        private int x, y;
        private bool move;
        public SetPassword()
        {
            InitializeComponent();
        }

        private void topBar1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            move = true;
        }

        private void topBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }

        }

        private void newPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                confirmPassword.Focus();
            }
        }

        private void confirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (newPassword.Text != "")
                    {
                        if (newPassword.Text == confirmPassword.Text)
                        {
                            connection.Open();
                            string query = "INSERT INTO DataTable (name, thing) VALUES ('Password', '" + newPassword.Text + "')";
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                            sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                            connection.Close();
                            this.Hide();
                            MBox mBox = new MBox("Password successfully set");
                            mBox.ShowDialog();
                            Password password = new Password();
                            password.Show();
                        }
                        else
                        {
                            MBox mBox = new MBox("Both passwords should be same");
                            mBox.ShowDialog();
                        }
                    }
                    else
                    {
                        MBox mBox = new MBox("Password at least should be one character");
                        mBox.ShowDialog();
                    }
                }
            }
            catch(Exception ex)
            {
                MBox mBox = new MBox(ex.ToString());
                mBox.ShowDialog();
            }
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topBar1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
