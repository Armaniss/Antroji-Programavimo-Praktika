using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Praktinis_darbas
{
    public class StaticData
    {
        public static string ConnectionString()
        {
           return (@"Data Source=DESKTOP-GHTTGVL;Initial Catalog=bibliotekos_valdymo_sistema;Integrated Security=True;Pooling=False");

        }

        


    }
}
