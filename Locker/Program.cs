using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Locker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.MDBConnectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                connection.Open();
                string query = "SELECT * FROM DataTable WHERE name = 'Password'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                connection.Close();
                if (dataTable.Rows.Count == 1)
                {
                    Application.Run(new Password());
                }
                else
                {
                    Application.Run(new SetPassword());
                }
            }
            catch(Exception ex)
            {
                MBox mBox = new MBox(ex.ToString());
                mBox.ShowDialog();
                mBox = new MBox("Something's wrong, we need to restart apllication");
                mBox.ShowDialog();
                Application.Restart();
            }
        }
    }
}
