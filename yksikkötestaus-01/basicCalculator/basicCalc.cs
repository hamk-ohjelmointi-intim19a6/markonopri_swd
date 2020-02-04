using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    class basicCalc
    {
        public int Add(int x, int y)    // funktio yhteenlaskulle
        {
            return x + y;
        }
        public int Sub(int x, int y)    // funktio vähennyslaskulle
        {
            return x - y;
        }
        public int Mul(int x, int y)    // funktio kertolaskulle
        {
            return x * y;
        }
        public int Div(int x, int y)    // funktio jakolaskulle
        {
            return x / y;
        }
        public int Jak(int x, int y)    // funktio jakojäännökselle
        {
            return x % y;
        }
    }
}
