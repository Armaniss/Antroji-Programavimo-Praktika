using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static Praktinis_darbas.StaticData;

namespace Praktinis_darbas
{
    class Studentas : Asmuo
    {
        SqlConnection con = new SqlConnection(ConnectionString());
        private int sarasonr;
        private string grupe;
        private string nuotrauka;
        private List<Knyga> knygos = new List<Knyga>();
        private List<Studentas> studentai = new List<Studentas>();
        public Studentas(string pilnasvardas,string elpastas,int numeris,int sarasonr,string grupe)
        {
            this.pilnasvardas = pilnasvardas;
            //this.slapyvardis = slapyvardis;
            //this.slaptazodis = slaptazodis;
            this.elpastas = elpastas;
            this.numeris = numeris;
            this.sarasonr = sarasonr;
            this.grupe = grupe;
            //this.nuotrauka = nuotrauka;
        }
        
        public int get_sarasonr()
        {
            return sarasonr;
        }
        public string get_grupe()
        {
            return grupe;
        }
        public string get_nuotrauka()
        {
            return nuotrauka;
        }
        public List<Knyga> GetKnygos()
        {
            return knygos;
        }
        public List<Studentas> GetStudentai()
        {
            return studentai;
        }
        public void Studentu_Itraukimas()
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from studentas_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                studentai.Add(new Studentas(dr["studento_vardas"].ToString(), dr["studento_elpastas"].ToString(), Convert.ToInt32(dr["studento_numeris"].ToString()), Convert.ToInt32(dr["studento_sarasonr"].ToString()), dr["studento_grupe"].ToString()));
            }
        }
    }
}
