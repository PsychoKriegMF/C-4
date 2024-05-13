//Наследование и полиморфизм, и основные парадигмы ООП
using Zoo;

namespace C_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger t = new Tiger("Pups", "Austria");
            t.Info();
            t.lives();

            Krokodile krock = new Krokodile("Gena", "Africa");
            krock.Info();
            krock.lives();
            //Console.ReadKey(true);

        }
    }
    public abstract class CDA 
    {
        public abstract void B(int x);
    }

    public class ABC // запрещенный для наследования - public sealed class ABC
    {
        public ABC() { }   
        
        public virtual void A() { }        
    }

    public class BCA : ABC 
    {
        public BCA() : base () { }
    }

    


}


