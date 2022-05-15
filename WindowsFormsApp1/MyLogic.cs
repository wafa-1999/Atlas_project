using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MyLogic
    {

        public bool CheckPass(int a, int b, int c)
        {

            if (a == b)
            {
                Console.WriteLine("Nouveau client, passer a la forme client");
                return true;
            }
            else if (a == c)
            {
                Console.WriteLine("Tu as deja inscrit, passer a la menu");
                return true;
            }
            else
            {
                return false;

            }
        }
       
    }
}
