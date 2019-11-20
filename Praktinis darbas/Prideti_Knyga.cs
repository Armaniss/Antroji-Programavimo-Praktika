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
    public partial class Prideti_Knyga : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString());
        
        public Prideti_Knyga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into knyga_informacija values('"+ textBox1.Text +"','"+ textBox2.Text + "','"+ textBox3.Text + "',"+ textBox4.Text + ",'"+ textBox5.Text + "',"+ textBox6.Text + "," + textBox6.Text + ")";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Knyga sekmingai itraukta i sarasa");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
