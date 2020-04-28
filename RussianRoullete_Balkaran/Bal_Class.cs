using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoullete_Balkaran
{
    public class Bal_Class//This is class for variables and functions
    {
        public int Ld { get; set; }
        public int Spn { get; set; }

        public int Shot(int skipShoot)
        {
            if (skipShoot == 6)
            {
                skipShoot = 1;
            }
            else
            {
                skipShoot++;
            }
            return skipShoot;
        }
    }
}
