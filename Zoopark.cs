using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoo
{
    public class Zoopark
    {


        public string Name {  get; set; }
        public string ToLives {  get; set; }

        public Zoopark(string name, string tolives) 
        {
            this.Name = name;
            this.ToLives = tolives;
        }
        public virtual void Info()
        {
            Console.WriteLine($"{Name}");
        }
        public virtual void lives() 
        {
            Console.WriteLine($"{ToLives}");
        }

    }
}
