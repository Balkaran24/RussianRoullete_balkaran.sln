using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoullete_Balkaran
{
    public class UnitTestCase
    {
        public int AddTwoPostiveNumber(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return -1;
            }
            return a + b;
        }
    }
}
