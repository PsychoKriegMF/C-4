using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass
{
    public class Passport
    {
        public int serial {  get; set; }
        public int number {  get; set; }

        public string country {  get; set; }

        public Passport(int serial, int number, string country)
        {
            this.serial = serial;
            this.number = number;
            this.country = country;
        }

        public virtual void Ser()
        {
            Console.Write("Serial: ");
        }
        public virtual void Num() 
        {
            Console.Write("Number: ");
        }
        public virtual void Count()
        {
            Console.Write("Counrty: ");
        }
    }
}
