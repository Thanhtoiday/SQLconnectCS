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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataSet getAllUser()

        {
            try
            {
                DataSet data = new DataSet();
                string sql = "select * from SV";

                using (SqlConnection conn  = new SqlConnection(StringConnect.StringConn))
                {
                    conn.Open();


                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(data);
                    conn.Close();
                }
                return data;

            }catch (Exception ex)
            {
                MessageBox.Show("Không thể truy cập ");
            }return null;
        }
        
      

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            id_txt.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            msv_txt.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            name_txt.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            Khoa_txt.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
        
    }

        private void refesh_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = getAllUser().Tables[0];
        }
    }
}
