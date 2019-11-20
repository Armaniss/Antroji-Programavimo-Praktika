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
    public partial class Isduoti_knygas : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString());      
        
        public Isduoti_knygas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from studentas_info where studento_sarasonr = '"+ txt_sarasonr.Text +"' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if(i==0)
            {
                MessageBox.Show("Saraso numeris nerastas");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txt_vardas.Text = dr["studento_vardas"].ToString();
                    txt_grupe.Text = dr["studento_grupe"].ToString();
                    txt_numeris.Text = dr["studento_numeris"].ToString();
                    txt_elpastas.Text = dr["studento_elpastas"].ToString();
                    txt_vardas.Text = dr["studento_vardas"].ToString();

                    Studentas studentas = new Studentas(txt_vardas.Text, txt_elpastas.Text, Convert.ToInt32(txt_numeris.Text), Convert.ToInt32(txt_sarasonr.Text), txt_grupe.Text);

                }
            }
            

        }

        private void Isduoti_knygas_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_pavadinimas_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;

            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from knyga_informacija where knyga_pavadinimas like('%" + txt_pavadinimas.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count > 0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["knyga_pavadinimas"].ToString());
                    }
                }
            }
        }

        private void txt_pavadinimas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
            
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_pavadinimas.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_pavadinimas.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int knyga_kiekis = 0;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from knyga_informacija where knyga_pavadinimas = '"+ txt_pavadinimas.Text +"'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                knyga_kiekis = Convert.ToInt32(dr2["galimas_kiekis"].ToString());
            }

            if (knyga_kiekis > 0)
            { 
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into isduoti_knygas values ('"+ txt_sarasonr.Text +"','"+ txt_vardas.Text +"','"+ txt_grupe.Text +"','"+ txt_numeris.Text+"','"+ txt_elpastas.Text+"','"+ txt_pavadinimas.Text +"','"+ dateTimePicker1.Value.ToShortDateString() +"','')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update knyga_informacija set galimas_kiekis=galimas_kiekis-1 where knyga_pavadinimas = '"+ txt_pavadinimas.Text +"'";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Knyga sekmingai isduota");
            }
            else
            {
                MessageBox.Show("Knyga negali būti išduota dėl pasibaigusio likučio");
            }
        }
    }
}
