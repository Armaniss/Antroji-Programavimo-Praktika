using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;
using System.Data;

namespace Praktinis_darbas
{
    public class Class1
    {
        public static string GetRandomPassword(int lenght)
        {
            char[] chars = "abcdefghijklmnopqrstuvxyz1234567890ABDEFGHIJKLMNOPQRSTUVXYZ".ToCharArray();
            string password = string.Empty;
            Random random = new Random();

            for (int i = 0; i < lenght; i++)
            {
                int x = random.Next(1, chars.Length);

                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else i = i - 1;
            }
            return password;
        }
        
    }
}
