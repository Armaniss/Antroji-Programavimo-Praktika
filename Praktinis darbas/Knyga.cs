using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis_darbas
{
    class Knyga
    {
        private string pavadinimas;    
        private string isdavimodata;
        private string grazinimodata;

        public Knyga(string pavadinimas,string isdavimodata,string grazinimodata)
        {
            this.pavadinimas = pavadinimas;          
            this.isdavimodata = isdavimodata;
            this.grazinimodata = grazinimodata;
        }

        public string get_pavadinimas()
        {
            return pavadinimas;
        }
        public string get_isdavimodata()
        {
            return isdavimodata;
        }
        public string get_grazinimodata()
        {
            return grazinimodata;
        }
    }
}
