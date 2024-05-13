using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_4
{
    public class Rhomb : Geometric
    {
        public int A {  get; set; } // основание
        public int H {  get; set; } // высота

        public Rhomb(int A, int H) 
        { 
            this.A = A;
            this.H = H;
        }
        public override double S()
        {
            return A * H;
        }
        public override double P()
        {
            return 4 * A;
        }
    }
}
