using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Locker
{
    public partial class Password : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.MDBConnectionString);
        private int x, y;
        private bool move;
        public Password()
        {
            InitializeComponent();
            move = false;
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string query = "SELECT * FROM DataTable WHERE name='Password' and thing='" + textBox.Text + "'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    if (table.Rows.Count == 1)
                    {
                        this.Hide();
                        Main main = new Main();
                        main.Show();
                    }
                    else
                    {
                        MBox mBox = new MBox("Wrong password");
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

        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
