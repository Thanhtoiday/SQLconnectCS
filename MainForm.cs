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

<<<<<<< HEAD
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataSet getAllUser()
=======
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        //lay du lieu do vao datagridview bang dataset
        DataSet getAlluser()//muc dich lay du lieu
>>>>>>> b89e149e8654dfad20f66ae5b38f93bab1bf7699
        {
            try
            {
                DataSet data = new DataSet();
                string sql = "select * from SV";
<<<<<<< HEAD
                using (SqlConnection conn  = new SqlConnection(StringConnect.StringConn))
                {
                    conn.Open();
=======
                using (SqlConnection conn = new SqlConnection(StringConnect.StringConn))
                {
                    conn.Open();

>>>>>>> b89e149e8654dfad20f66ae5b38f93bab1bf7699
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(data);
                    conn.Close();
                }
                return data;
<<<<<<< HEAD
            }catch (Exception ex)
            {
                MessageBox.Show("Không thể truy cập ");
            }return null;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = getAllUser().Tables[0];
=======
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
>>>>>>> b89e149e8654dfad20f66ae5b38f93bab1bf7699
        }
    }
}
