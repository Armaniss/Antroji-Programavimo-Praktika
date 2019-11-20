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
    public partial class St_Pasiimti_Knyga : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString());
       
        List<Studentas> studentai = new List<Studentas>();
        List<Knyga> knygos = new List<Knyga>();
        public St_Pasiimti_Knyga()
        {
            InitializeComponent();
        }

        private void St_Pasiimti_Knyga_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from studentas_info where studento_sarasonr = '" + this.Name.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int i = 0;

            foreach (DataRow dr in dt.Rows)
            {
                if(i==0)
                {
                    studentai.Add(new Studentas(dr["studento_vardas"].ToString(), dr["studento_elpastas"].ToString(), Convert.ToInt32(dr["studento_numeris"].ToString()), Convert.ToInt32(dr["studento_sarasonr"].ToString()), dr["studento_grupe"].ToString()));
                }
                txt_vardas.Text = dr["studento_vardas"].ToString();
                txt_grupe.Text = dr["studento_grupe"].ToString();
                txt_numeris.Text = dr["studento_numeris"].ToString();
                txt_elpastas.Text = dr["studento_elpastas"].ToString();
                txt_vardas.Text = dr["studento_vardas"].ToString();
                txt_sarasonr.Text = dr["studento_sarasonr"].ToString();
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            int knyga_kiekis = 0;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from knyga_informacija where knyga_pavadinimas = '" + txt_pavadinimas.Text + "'";
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
                cmd.CommandText = "insert into isduoti_knygas values ('" + txt_sarasonr.Text + "','" + txt_vardas.Text + "','" + txt_grupe.Text + "','" + txt_numeris.Text + "','" + txt_elpastas.Text + "','" + txt_pavadinimas.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update knyga_informacija set galimas_kiekis=galimas_kiekis-1 where knyga_pavadinimas = '" + txt_pavadinimas.Text + "'";
                cmd1.ExecuteNonQuery();
                

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from isduoti_knygas where studento_vardas = '" + this.Text.ToString() + "' and knygos_pavadinimas = '"+ txt_pavadinimas.Text +"'";
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dt3);
                foreach (Studentas studentas in studentai)
                {
                    if(studentas.get_pilnasvardas() == this.Text.ToString())
                    {
                        foreach (DataRow dr2 in dt3.Rows)
                        {
                            studentas.GetKnygos().Add(new Knyga(dr2["knygos_pavadinimas"].ToString(), dr2["knygos_isdavimodata"].ToString(), dr2["knygos_grazinimodata"].ToString()));
                        }
                        
                    }
                }
                MessageBox.Show("Knyga sekmingai isduota");
                this.Close();

            }
            else
            {
                MessageBox.Show("Knyga negali būti išduota dėl pasibaigusio likučio");
            }
        }

        private void txt_pavadinimas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pavadinimas.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //Nereikalingas 
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_pavadinimas.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //nereikalingas
        }
    }
}
