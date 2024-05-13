using Pass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass
{
    public class ForeignPassport : Passport
    {
        public int serial { get; set; }
        public int number { get; set; }
        public string country { get; set; }

        public int serial_number {  get; set; }
        public int id {  get; set; }

        public ForeignPassport(int serial, int number, string country) : base(serial,number,country)  { }

        public override void Count()
        {
            Console.WriteLine("Country: ");
            base.Count();
        }

        public override void Num()
        {
            Console.WriteLine("Number: ");
            base.Num();
        }

        public override void Ser()
        {
            Console.WriteLine("Serial: ");
            base.Ser();
        }





    }
}
