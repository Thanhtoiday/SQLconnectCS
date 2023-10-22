using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQLconnectCS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = tk_txt.Text;
            string mk = mk_txt.Text;
          
            //dung window auth
            //dung sysadmin
            using (SqlConnection conn = new SqlConnection(StringConnect.StringConn)) {
                try
                {
                    conn.Open();
                    //sql injection
                    string sql = "select count(*) from SV where msv = @tk and ten = @mk";
                    //sql này trả về 1 hoặc  0
                    //tao cmd chua cau lenh truy vấn và kết nối
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlParameter tkparam = new SqlParameter();
                    tkparam.ParameterName = "@tk";
                    tkparam.Value = tk;
                    SqlParameter mkparam  = new SqlParameter();
                    mkparam.ParameterName = "@mk";
                    mkparam.Value = mk;
                    cmd.Parameters.Add( tkparam );
                    cmd.Parameters.Add( mkparam );
                    var flag =(int) cmd.ExecuteScalar();
                    //flag sẽ bằng 1 or -1
                    if(flag != 0)
                    {
                        MessageBox.Show("kết nối thành công");
                        MainForm mf = new MainForm();
                        this.Hide();
                        mf.ShowDialog();
                        
                       
                       
                    }
                    else
                    {
                        MessageBox.Show("Khoog thể kết nối");
                    }
                   
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kết nối");
                }
            }
            // getAlluser tương đương select * from
            //lay dữ liệu từ sql đổ vào datagridview 



            }


        }


    }

