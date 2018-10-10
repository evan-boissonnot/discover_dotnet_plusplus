using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class AAnimal
    {
        public virtual string Talk() => "AAnimal";
    }

    public class Feline :AAnimal
    {
        public override string Talk() => base.Talk() + " Feline";
    }

    public interface ITalkative
    {
        string Talk();
    }

    public class Cat : Feline, ITalkative
    {
        public override string Talk() => "Cat";
        string ITalkative.Talk() =>"Talkative cat";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            Console.WriteLine(cat.Talk());
            Console.WriteLine(((ITalkative)cat).Talk());
            Console.WriteLine(((Feline)cat).Talk());
            Console.WriteLine(((AAnimal)cat).Talk());

        }
    }
}
