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

namespace Praktinis_darbas
{
    public partial class mdi_vartotojas : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GHTTGVL;Initial Catalog=bibliotekos_valdymo_sistema;Integrated Security=True;Pooling=False");
        static List<Studentas> studentai = new List<Studentas>();
        private int childFormNumber = 0;

        public mdi_vartotojas()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pridetiNaujaKnygaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prideti_Knyga pk = new Prideti_Knyga();
            pk.Show();
        }

        private void perziuretiKnygasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Knygu_Perziura kp = new Knygu_Perziura();
            kp.Show();
        }

        private void pridėtiStudentąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentas_info si = new studentas_info();
            si.Show();
        }

        private void peržiūrėtiStudentusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perziureti_studentus ps = new Perziureti_studentus();
            ps.Show();
        }

        private void išduotiKnygaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Isduoti_knygas ik = new Isduoti_knygas();
            ik.Show();
        }

        private void gražintiKnygaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Knygu_grazinimas kg = new Knygu_grazinimas();
            kg.Show();
        }

        private void išvestinėToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Knygu_ataskaita ka = new Knygu_ataskaita();
            ka.Show();
        }

        private void mdi_vartotojas_Load(object sender, EventArgs e)
        {
                
        }
        
    }
}
