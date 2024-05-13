using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo;

namespace Zoo
{
    public class Kenguroo : Zoopark
    {
        public string Name { get; set; }
        public string ToLives { get; set; }
        public Kenguroo(string name, string tolives) : base(name, tolives) { }
        public override void Info()
        {
            Console.WriteLine("Kenguroo: ");
            base.Info();
        }
        public override void lives()
        {
            Console.WriteLine("Obitaet: ");
            base.lives();
        }


    }
}
