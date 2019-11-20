using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis_darbas
{
    class Asmuo
    {
        protected string pilnasvardas;
        protected string slapyvardis;
        protected string slaptazodis;
        protected string elpastas;
        protected int numeris;

        public Asmuo()
        {
            pilnasvardas = "";
            slapyvardis = "";
            slaptazodis = "";
            elpastas = "";
            //numeris = Convert.ToInt32("");
            
        }
        public string get_pilnasvardas()
        {
            return pilnasvardas;
        }

        public string get_slapyvardis()
        {
            return slapyvardis;
        }

        public string get_slaptazodis()
        {
            return slaptazodis;
        }

        public string get_elpastas()
        {
            return elpastas;
        }
        public int get_numeris()
        {
            return numeris;
        }
    }
}
