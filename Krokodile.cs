using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo;

namespace Zoo
{
    public class Krokodile : Zoopark
    {
        public string Name { get; set; }
        public string ToLives { get; set; }
        public Krokodile(string name, string tolives) : base(name, tolives) { }     
        
        public override void Info()
        {
            Console.Write("Krokodile: ");
            base.Info();
        }
        public override void lives()
        {
            Console.Write("Obitaet: ");
            base.lives();
        }


    }
}
