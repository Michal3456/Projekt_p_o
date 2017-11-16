using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class metod_og
    {
        public static string zwroc_int_jesli_ci_s_r(string a)
        {
            if (a.Equals("op1"))
                return "1";
            else
                 if (a.Equals("op2"))
                return "2";
            else
                if (a.Equals("op3"))
                return "3";
            else
                if (a.Equals("op4"))
                return "4";
            else
                if (a.Equals("op5"))
                return "5";
            else
                return "6";

        }
    }
}
