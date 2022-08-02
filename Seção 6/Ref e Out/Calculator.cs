using System;
using System.Collections.Generic;
using System.Text;

namespace Ref_e_Out
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
