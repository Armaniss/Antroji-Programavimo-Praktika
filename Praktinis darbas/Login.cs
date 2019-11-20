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
using static Praktinis_darbas.StaticData;

namespace Praktinis_darbas 
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString());
        


        int count = 0;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = " select * from studentas_info where studento_vardas = '"+ textBox1.Text +"' and studento_sarasonr = '"+ textBox2.Text +"'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                count = Convert.ToInt32(dt1.Rows.Count.ToString());
                if (count == 0)
                {
                    MessageBox.Show("Studentas neegzistuoja");
                }
                else
                {
                    this.Hide();
                    MDIParent1 mdi = new MDIParent1();
                    mdi.Name = textBox2.Text.ToString();
                    mdi.Text = textBox1.Text.ToString();
                    mdi.Show();
                }
            }
            else
            {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from biblioteka_asmuo where slapyvardis = '"+ textBox1.Text +"' and slaptazodis = '"+ textBox2.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("neteisingas slapyvardis arba slaptazodis");
            }
            else
            {
                this.Hide();
                mdi_vartotojas mv = new mdi_vartotojas();
                mv.Show();
            }
            }
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
