using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_4
{
    public class Parallelogram : Geometric
    {
        public int A {  get; set; }
        public int B { get; set; }

        public Parallelogram(int A, int B) 
        {
            this.A = A; 
            this.B = B;
        }

        public override double S()
        {
            return A * B * Math.Sin(A);
        }
        public override double P()
        {
            return (A + B) * 2;
        }
    }
}
