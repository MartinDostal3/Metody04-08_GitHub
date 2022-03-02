using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08_GitHub
{
    class CelaCisla
    {
        public static double mocnina(double a, int n)
        {
            double mocnina = 1;

            if (n < 0)
            {
                for (int i = 1; i <= n * (-1); ++i)
                {
                    mocnina /= a;
                }
            }
            else
            {
                for (int i = 1; i <= n; ++i)
                {
                    mocnina *= a;
                }
            }

          

            return mocnina;
        }


    }
}
