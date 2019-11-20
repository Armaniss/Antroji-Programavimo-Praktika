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
using System.IO;
using static Praktinis_darbas.StaticData;
namespace Praktinis_darbas
{
    public partial class Perziureti_studentus : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString());
        
        string pass = Class1.GetRandomPassword(20);
        string wanted_path;
        DialogResult result;
        public Perziureti_studentus()
        {
            InitializeComponent();
        }

        private void Perziureti_studentus_Load(object sender, EventArgs e)
        {
            
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            //int i = 0;
            fill_grid();
             /*
            Bitmap img;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Width = 500;
            imageCol.HeaderText = "studento nuotrauka";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageCol.Width = 100;
            dataGridView1.Columns.Add(imageCol);

            foreach (DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\" + dr["studento_nuotrauka"].ToString());               
                dataGridView1.Rows[i].Cells[7].Value = img;
                dataGridView1.Rows[i].Height = 100;
                i = i + 1;
            }
            */

        }
        public void fill_grid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from studentas_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from studentas_info where studento_vardas like ('%"+ textBox1.Text +"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from studentas_info where id = "+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                studentovardas.Text = dr["studento_vardas"].ToString();
                studentosarasonr.Text = dr["studento_sarasonr"].ToString();
                studentogrupe.Text = dr["studento_grupe"].ToString();
                studentotel.Text = dr["studento_numeris"].ToString();
                studentoemail.Text = dr["studento_elpastas"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG files(*.png)|*.png|JPG files (*.jpg)|*.jpg";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK)
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                string img_path;
                File.Copy(openFileDialog1.FileName, wanted_path + "\\studento_nuotraukos\\" + pass + ".jpg");
                img_path = "studento_nuotraukos\\" + pass + ".jpg";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update studentas_info set studento_vardas = '"+ studentovardas.Text +"',studento_nuotrauka = '"+ img_path.ToString() +"',studento_sarasonr = '"+ studentosarasonr.Text +"',studento_grupe = '"+ studentogrupe.Text +"',studento_numeris = '"+ studentotel.Text +"',studento_elpastas = '"+ studentoemail.Text +"' where id = "+i+"";
                cmd.ExecuteNonQuery();
                fill_grid();
                MessageBox.Show("Sekmingai atnaujinta");
                
            }
            else if(result == DialogResult.Cancel)
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update studentas_info set studento_vardas = '" + studentovardas.Text + "',studento_sarasonr = '" + studentosarasonr.Text + "',studento_grupe = '" + studentogrupe.Text + "',studento_numeris = '" + studentotel.Text + "',studento_elpastas = '" + studentoemail.Text + "' where id = " + i + "";
                cmd.ExecuteNonQuery();
                fill_grid();
                MessageBox.Show("Sekmingai atnaujinta");
            }
        }
    } 
}
