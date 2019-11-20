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
    public partial class St_Knygu_Grazinimas : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString());
        

        public St_Knygu_Grazinimas()
        {
            InitializeComponent();
        }

        private void St_Knygu_Grazinimas_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            panel2.Visible = true;
            Fill_grid(this.Name.ToString());
        }
        public void Fill_grid(string sarasonr)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from isduoti_knygas where studento_sarasonumeris = '" + sarasonr.ToString() + "' and knygos_grazinimodata = ''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from isduoti_knygas where id = " + i + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lbl_pavadinimas.Text = dr["knygos_pavadinimas"].ToString();
                lbl_isdavimas.Text = dr["knygos_isdavimodata"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update isduoti_knygas set knygos_grazinimodata = '" + dateTimePicker1.Value.ToString() + "'";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update Knyga_informacija set galimas_kiekis = galimas_kiekis+1 where knyga_pavadinimas = '" + lbl_pavadinimas.Text + "'";
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Knyga gražinta sekmingai");
            panel3.Visible = false;

            Fill_grid(this.Name.ToString());


        }
    }
}
