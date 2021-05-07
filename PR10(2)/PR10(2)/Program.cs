using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR10
{
    class Program
    {
        abstract class animal
        {
            protected string habitat;
            protected string domain;
            protected string kingdoms;

            public abstract void input();
            public abstract void output();
        }

        class Monkey : animal
        {
            private string typeMonkey;
            private int amountBananaForDay;

            public override void input()
            {
                Console.Write("Input habitat: ");
                habitat = Console.ReadLine();
                Console.Write("Input domain: ");
                domain = Console.ReadLine();
                Console.Write("Input kingdoms: ");
                kingdoms = Console.ReadLine();
                Console.Write("Input type of monkey: ");
                typeMonkey = Console.ReadLine();
                Console.Write("Input amount banana for monkey for 1 day: ");
                amountBananaForDay = Convert.ToInt32(Console.ReadLine());
            }

            public override void output()
            {
                Console.WriteLine("Habitat: {0}\nDomain: {1}\nKingdoms: {2}\n" +
                    "Type of monkey: {3}\nAmount banana for monkey for 1 day: {4}", habitat, domain, kingdoms, typeMonkey, amountBananaForDay);
            }
        }

        class Lion : animal
        {
            private double kgMeatforweek;
            private string partner;

            public override void input()
            {
                Console.Write("Input habitat: ");
                habitat = Console.ReadLine();
                Console.Write("Input domain: ");
                domain = Console.ReadLine();
                Console.Write("Input kingdoms: ");
                kingdoms = Console.ReadLine();
                Console.Write("Input kg of meat for 1 week: ");
                kgMeatforweek = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input having a partner: ");
                partner = Console.ReadLine();

            }

            public override void output()
            {
                Console.WriteLine("Habitat: {0}\nDomain: {1}\nKingdoms: {2}\n" +
                    "Kg of meat for 1 week: {3}\nHaving a partner: {4}", habitat, domain, kingdoms, kgMeatforweek, partner);
            }

        }

        static void Main(string[] args)
        {
            Monkey monkey = new Monkey();
            monkey.input();
            Console.WriteLine("\n");
            monkey.output();

            Console.WriteLine("\n");

            Lion lion = new Lion();
            lion.input();
            Console.WriteLine("\n");

            lion.output();

            Console.ReadLine();
        }

    }
}
