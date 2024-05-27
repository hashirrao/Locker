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
    public partial class ChangePassword : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.MDBConnectionString);
        private int x, y;
        private bool move;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currentPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                newPassword.Focus();
            }
        }

        private void newPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmPassword.Focus();
            }
        }

        private void confirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string getQuery = "SELECT * FROM DataTable WHERE name='Password' and thing='"+ currentPassword.Text +"'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(getQuery, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    if (newPassword.Text != "")
                    {
                        if (newPassword.Text == confirmPassword.Text)
                        {
                            connection.Open();
                            string updateQuery = "UPDATE DataTable SET thing='" + newPassword.Text + "' WHERE name='Password'";
                            dataAdapter = new SqlDataAdapter(updateQuery, connection);
                            dataAdapter.SelectCommand.ExecuteNonQuery();
                            connection.Close();
                            this.Hide();
                            MBox mBox = new MBox("Password successfully changed");
                            mBox.ShowDialog();
                        }
                        else
                        {
                            MBox mBox = new MBox("New password and confirm password must be same");
                            mBox.ShowDialog();
                        }
                    }
                    else
                    {
                        MBox mBox = new MBox("Password should be at least one character");
                        mBox.ShowDialog();
                    }
                }
                else
                {
                    MBox mBox = new MBox("Current password is wrong");
                    mBox.ShowDialog();
                }
            }
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

        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
