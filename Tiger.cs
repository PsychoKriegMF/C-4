using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tiger : Zoopark
    {
        public string Name { get; set; }
        public string ToLives { get; set; }
        public Tiger(string name, string tolives) : base(name, tolives) { }
        
        public override void Info()
        {
            Console.Write("Tiger: ");
            base.Info();
        }
        public override void lives()
        {
            Console.Write("Obitaet: ");
            base.lives();
        }


    }
}
