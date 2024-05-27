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
using System.IO;
using System.Threading;

namespace Locker
{
    public partial class Main : Form
    {
        private int x, y, rowIndex;
        private bool move;
        private String[] addFiles;
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.MDBConnectionString);
        //SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\#\source\repos\Locker\Locker\MainDatabase.mdf;Integrated Security=True");
        OpenFileDialog dialog = new OpenFileDialog();
        public Main()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (deleteBGWorker.IsBusy || addBGWorker.IsBusy || retrieveBGWorker.IsBusy)
            {
                return;
            }
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                addFiles = dialog.FileNames;
                addBGWorker.RunWorkerAsync(addFiles);
            }
            progressBar.Minimum = 0;
            progressBar.Value = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowDrop = true;
            searchBox.Text = "  SEARCH  ";
            refreshDataGridView();
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            if (deleteBGWorker.IsBusy || addBGWorker.IsBusy || retrieveBGWorker.IsBusy)
            {
                return;
            }
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            retrieveBGWorker.RunWorkerAsync();
        }

        private void changePassworButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (addBGWorker.IsBusy || retrieveBGWorker.IsBusy || deleteBGWorker.IsBusy)
            {
                MBox mBox = new MBox("Please wait until processing is completed");
                mBox.ShowDialog();
                return;
            }
            Application.Exit();
        }

        private void maximizeButton1_Click(object sender, EventArgs e)
        {
            if (addBGWorker.IsBusy || retrieveBGWorker.IsBusy || deleteBGWorker.IsBusy)
            {
                return;
            }
            maximize();
        }

        private void minimizeButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topBar1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            move = true;
        }

        private void topBar1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                connection.Open();
                SqlDataAdapter dataAdapter;
                string getQuery = "SELECT * FROM DataTable WHERE name='Address'";
                dataAdapter = new SqlDataAdapter(getQuery, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    string updateQuery = "UPDATE DataTable SET thing='" + dialog.SelectedPath + "' WHERE name='Address'";
                    dataAdapter = new SqlDataAdapter(updateQuery, connection);
                    dataAdapter.SelectCommand.ExecuteNonQuery();
                }
                else
                {
                    string setQuery = "INSERT INTO DataTable (name, thing) VALUES ('Address', '" + dialog.SelectedPath + "')";
                    dataAdapter = new SqlDataAdapter(setQuery, connection);
                    dataAdapter.SelectCommand.ExecuteNonQuery();
                }
                MBox mBox = new MBox("Path successfully selected");
                mBox.ShowDialog();
                connection.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteBGWorker.IsBusy || addBGWorker.IsBusy || retrieveBGWorker.IsBusy)
            {
                return;
            }
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            deleteBGWorker.RunWorkerAsync();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenu.Show(dataGridView1, new Point(x, y));
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deleteBGWorker.IsBusy || addBGWorker.IsBusy || retrieveBGWorker.IsBusy)
            {
                return;
            }
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            deleteBGWorker.RunWorkerAsync();
        }

        private void retrieveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deleteBGWorker.IsBusy || addBGWorker.IsBusy || retrieveBGWorker.IsBusy)
            {
                return;
            }
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            retrieveBGWorker.RunWorkerAsync();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (deleteBGWorker.IsBusy || addBGWorker.IsBusy || retrieveBGWorker.IsBusy)
                {
                    return;
                }
                progressBar.Minimum = 0;
                progressBar.Value = 0;
                deleteBGWorker.RunWorkerAsync();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (deleteBGWorker.IsBusy || addBGWorker.IsBusy || retrieveBGWorker.IsBusy)
                {
                    return;
                }
                progressBar.Minimum = 0;
                progressBar.Value = 0;
                retrieveBGWorker.RunWorkerAsync();
            }
        }

        private void topBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void openOutputButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DataTable WHERE name='Address'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            string path = "";
            if (table.Rows.Count != 1)
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            else
            {
                path = table.Rows[0]["thing"].ToString();
            }
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void totalItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MBox mBox = new MBox("No of items = " + dataGridView1.Rows.Count);
            mBox.ShowDialog();
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void topBar1_DoubleClick(object sender, EventArgs e)
        {
            maximize();
        }

        private void refreshDataGridView()
        {
            try
            {
                if (searchBox.Text == "" || searchBox.Text == "  SEARCH  ")
                {
                    string query = "SELECT filename FROM MainTable";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                    dataGridView1.Columns[0].Width = dataGridView1.Width - 3;
                }
                else
                {
                    string query = "SELECT filename FROM MainTable WHERE filename LIKE '" + searchBox.Text + "%'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                    dataGridView1.Columns[0].Width = dataGridView1.Width - 3;
                }
            }
            catch (Exception ex)
            {
                MBox mBox = new MBox(ex.ToString());
                mBox.ShowDialog();
                mBox = new MBox("Something's went wrong we need to restart application");
                mBox.ShowDialog();
                Application.Restart();
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            if (deleteBGWorker.IsBusy || addBGWorker.IsBusy || retrieveBGWorker.IsBusy)
            {
                return;
            }
            addFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            addBGWorker.RunWorkerAsync(addFiles);
            progressBar.Minimum = 0;
            progressBar.Value = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (addBGWorker.IsBusy || retrieveBGWorker.IsBusy || deleteBGWorker.IsBusy)
            {
                return;
            }
            refreshDataGridView();
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            searchBox.Text = "  SEARCH  ";
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {
            if (addBGWorker.IsBusy || retrieveBGWorker.IsBusy || deleteBGWorker.IsBusy)
            {
                return;
            }
            if (searchBox.Visible == false)
            {
                searchPictureBox.Size = new Size(294, 27);
                searchPictureBox.Location = new Point(this.Width/2 - searchPictureBox.Width/2, 26);
                searchPictureBox.BackgroundImage = Properties.Resources.textfield;
                searchPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                searchBox.Visible = true;
                searchBox.Focus();
            }
        }

        private void searchPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            searchPictureBox.Size = new Size(searchPictureBox.Width -2, searchPictureBox.Height -2);
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteAll();
        }

        private void maximize()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            refreshDataGridView();
        }
        void pleaseWait()
        {
            MBox mBox = new MBox("Please wait...", "Simple Message");
            mBox.ShowDialog();
        }
        bool messageShow;
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            String[] files = addFiles;
            messageShow = true;
            try
            {
                int index = 1;
                foreach (string s in files)
                {
                    bool asciiCheck = false;
                    string sfname = Path.GetFileName(s);
                    char[] ch = sfname.ToCharArray();
                    for (int i = 0; i < ch.Length; i++)
                    {
                        if (ch[i] > 0 && ch[i] < 257)
                        {
                            asciiCheck = true;
                            if (ch[i] == '\'')
                            {
                                ch[i] = ' ';
                            }
                        }
                        else
                        {
                            asciiCheck = false;
                            break;
                        }
                    }
                    if (asciiCheck)
                    {
                        sfname = new string(ch);
                        connection.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "insert into MainTable (filename, [file]) values(@filename, @file)";
                        cmd.Parameters.AddWithValue("filename", sfname);
                        cmd.Parameters.AddWithValue("file", SqlDbType.VarBinary).Value = File.ReadAllBytes(s);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    else
                    {
                        MBox mBox1 = new MBox("File name is not valid, please rename and try again");
                        mBox1.ShowDialog();
                        messageShow = false;
                    }
                    if (!addBGWorker.CancellationPending)
                    {
                        addBGWorker.ReportProgress(index++ * 100 / files.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MBox mBox = new MBox(ex.ToString());
                mBox.ShowDialog();
                mBox = new MBox("Something's went wrong we need to restart application");
                mBox.ShowDialog();
                Application.Restart();
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void retrieveBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (selectedCellCount > 0)
                {
                    int index = 1;
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        connection.Open();
                        cmd.Connection = connection;
                        rowIndex = (dataGridView1.SelectedCells[i].RowIndex);
                        cmd.CommandText = "SELECT * FROM MainTable WHERE filename = '" + dataGridView1.Rows[rowIndex].Cells[0].Value.ToString() + "'";
                        dr = cmd.ExecuteReader();
                        byte[] bytes = null;
                        string filename = null;
                        while (dr.Read())
                        {
                            filename = dr.GetString(0);
                            bytes = (byte[])dr.GetValue(1);
                        }
                        dr.Close();
                        string query = "SELECT * FROM DataTable WHERE name='Address'";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        string path = "";
                        if (table.Rows.Count != 1)
                        {
                            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        }
                        else
                        {
                            path = table.Rows[0]["thing"].ToString();
                        }
                        string fileName = path + "\\" + filename;
                        Directory.CreateDirectory(Path.GetDirectoryName(fileName));
                        FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                        fileStream.Write(bytes, 0, bytes.Length);
                        fileStream.Close();
                        connection.Close();
                        if (!retrieveBGWorker.CancellationPending)
                        {
                            retrieveBGWorker.ReportProgress(index++ * 100 / selectedCellCount);
                        }
                    }
                    if (selectedCellCount > 1)
                    {
                        MBox mBox = new MBox("Files retrieved successfully");
                        mBox.ShowDialog();
                    }
                    else
                    {
                        MBox mBox = new MBox("File retrieved successfully");
                        mBox.ShowDialog();
                    }
                }
                else
                {
                    MBox mBox = new MBox("You must select something to retrieve");
                    mBox.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MBox mBox = new MBox(ex.ToString());
                mBox.ShowDialog();
                mBox = new MBox("Something's went wrong we need to restart application");
                mBox.ShowDialog();
                Application.Restart();
            }
        }

        private void retrieveBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void retrieveBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void deleteBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (selectedCellCount > 0)
                {
                    if (dataGridView1.AreAllCellsSelected(true))
                    {
                        deleteAll();
                    }
                    else
                    {
                        connection.Open();
                        MBox mBox1 = new MBox("Are you sure you want to delete....?", "");
                        if (mBox1.ShowDialog() == DialogResult.Yes)
                        {
                            SqlDataAdapter dataAdapter;
                            int index = 1;
                            for (int i = 0; i < selectedCellCount; i++)
                            {
                                rowIndex = (dataGridView1.SelectedCells[i].RowIndex);
                                string query = "DELETE FROM MainTable WHERE filename='" + dataGridView1.Rows[rowIndex].Cells[0].Value.ToString() + "'";
                                dataAdapter = new SqlDataAdapter(query, connection);
                                dataAdapter.SelectCommand.ExecuteNonQuery();
                                if (!deleteBGWorker.CancellationPending)
                                {
                                    deleteBGWorker.ReportProgress(index++ * 100 / selectedCellCount);
                                }
                            }
                            string query1 = "DBCC SHRINKFILE (MDB, 5)";
                            string query2 = "DBCC SHRINKFILE (MDB_log, 5)";
                            dataAdapter = new SqlDataAdapter(query1, connection);
                            dataAdapter.SelectCommand.ExecuteNonQuery();
                            dataAdapter = new SqlDataAdapter(query2, connection);
                            dataAdapter.SelectCommand.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                else
                {
                    MBox mBox = new MBox("You must select something to delete");
                    mBox.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MBox mBox = new MBox(ex.ToString());
                mBox.ShowDialog();
                mBox = new MBox("Something's went wrong we need to restart application");
                mBox.ShowDialog();
                Application.Restart();
            }
        }

        private void deleteBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void deleteBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            refreshDataGridView();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(10);
                if (messageShow)
                {
                    MBox mBox = new MBox("Files inserted succesfully");
                    mBox.ShowDialog();
                }
                refreshDataGridView();
            }
        }

        

        private void deleteAll()
        {
            try
            {
                connection.Open();
                MBox mBox1 = new MBox("Are you sure you want to delete....?", "");
                if (mBox1.ShowDialog() == DialogResult.Yes)
                {
                    mBox1 = new MBox("Warning:\nYour all data would be deleted\nAre you agree with it...?", "");
                    if (mBox1.ShowDialog() == DialogResult.Yes)
                    {
                        this.Enabled = false;
                        Thread thread = new Thread(pleaseWait);
                        thread.Start();
                        string query = "DELETE FROM MainTable";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                        dataAdapter.SelectCommand.ExecuteNonQuery();
                        string query1 = "DBCC SHRINKFILE (MDB, 5)";
                        string query2 = "DBCC SHRINKFILE (MDB_log, 5)";
                        dataAdapter = new SqlDataAdapter(query1, connection);
                        dataAdapter.SelectCommand.ExecuteNonQuery();
                        dataAdapter = new SqlDataAdapter(query2, connection);
                        dataAdapter.SelectCommand.ExecuteNonQuery();
                        thread.Abort();
                        this.Enabled = true;
                        refreshDataGridView();
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MBox mBox = new MBox(ex.ToString());
                mBox.ShowDialog();
                mBox = new MBox("Something's went wrong we need to restart application");
                mBox.ShowDialog();
                Application.Restart();
            }
        }
    }
    
}
