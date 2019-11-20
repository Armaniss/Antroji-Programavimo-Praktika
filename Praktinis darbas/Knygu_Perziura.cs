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
    public partial class Knygu_Perziura : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString());
       
        public Knygu_Perziura()
        {
            InitializeComponent();
        }

        private void Knygu_Perziura_Load(object sender, EventArgs e)
        {
            disp_books();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from knyga_informacija where knyga_pavadinimas like ('%"+ textBox1.Text +"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from knyga_informacija where knyga_pavadinimas like ('%" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from knyga_informacija where id = "+ i +"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    knygospavadinimas.Text = dr["knyga_pavadinimas"].ToString();
                    autorius.Text = dr["knyga_autorius"].ToString();
                    isleidimodata.Text = dr["knyga_isleidimo_data"].ToString();
                    ISBNkodas.Text = dr["knyga_ISBN"].ToString();
                    knygoskaina.Text = dr["knyga_kaina"].ToString();
                    knygukiekis.Text = dr["knyga_kiekis"].ToString();

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " update knyga_informacija set knyga_pavadinimas = '"+ knygospavadinimas.Text +"',knyga_autorius = '" + autorius.Text +"',knyga_isleidimo_data = '" + isleidimodata.Text +"',knyga_ISBN = " + ISBNkodas.Text +",knyga_kaina = '" + knygoskaina.Text +"',knyga_kiekis = " + knygukiekis.Text +" where id = "+i+"";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_books();
                MessageBox.Show("Informacija apie knyga sekmingai antnaujinta");
                panel2.Visible = false;
            }
            catch
            {

            }

        }

        public void disp_books()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from knyga_informacija ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
        public void knygos_load()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from knyga_informacija";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Knyga knyga = new Knyga(dr["knyga_pavadinimas"].ToString(), dr["knyga_autorius"].ToString(), Convert.ToInt64(dr["knyga_ISBN"].ToString()), Convert.ToDouble(dr["knyga_kaina"].ToString()), Convert.ToInt32(dr["knyga_kiekis"].ToString()), Convert.ToInt32(dr["galimas_kiekis"].ToString()));
                if (!knygos.Contains(knyga))
                {
                    knygos.Add(knyga);
                }
            }

            con.Close();
        }
        */
    }
}
