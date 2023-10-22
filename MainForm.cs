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

namespace SQLconnectCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        //lay du lieu do vao datagridview bang dataset
        DataSet getAlluser()//muc dich lay du lieu
        {
            try
            {
                DataSet data = new DataSet();
                string sql = "select * from SV";
                using (SqlConnection conn = new SqlConnection(StringConnect.StringConn))
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(data);
                    conn.Close();
                }
                return data;
            }catch(Exception ex)
            {
                MessageBox.Show("Khong the truy cap");
            }
            return null;
        }
        //show du lieu trong bang SV
        private void refesh_btn_Click(object sender, EventArgs e)
        {
            //setup do rong tu dong
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //do du lieu
            dataGridView1.DataSource = getAlluser().Tables[0];
        }
    }
}
