using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR10
{
    class Program
    {
        abstract class Plane
        {
            protected string name;
            protected double engineCapacity;
            protected double fullSpeed;

            public abstract void input();
            public abstract void output();
        }

        class Destroyer : Plane
        {
            private int amountRockets;
            private string mission;

            public override void input()
            {
                Console.Write("Input name: ");
                name = Console.ReadLine();
                Console.Write("Input engine capacity: ");
                engineCapacity = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input max speed: ");
                fullSpeed = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input amount of rockets: ");
                amountRockets = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input mission: ");
                mission = Console.ReadLine();
            }

            public override void output()
            {
                Console.WriteLine("Name: {0}\nEngine capacity: {1}\nMax speed: {2}\n" +
                    "Amount of rockets: {3}\nMission: {4}", name, engineCapacity,fullSpeed, amountRockets, mission);
            }
        }

        class PassangerLiner : Plane
        {
            private int amountPeople;
            private double priceTicket;

            public override void input()
            {
                Console.Write("Input name: ");
                name = Console.ReadLine();
                Console.Write("Input engine capacity: ");
                engineCapacity = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input max speed: ");
                fullSpeed = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input amount of people: ");
                amountPeople = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input price ticket: ");
                priceTicket = Convert.ToDouble(Console.ReadLine());
            }

            public override void output()
            {
                Console.WriteLine("Name: {0}\nEngine capacity: {1}\nMax speed: {2}\n" +
                    "Amount of people: {3}\nPrice ticket: {4}", name, engineCapacity, fullSpeed, amountPeople, priceTicket);
            }

        }

        static void Main(string[] args)
        {
            Destroyer destroyer = new Destroyer();
            destroyer.input();
            Console.WriteLine("\n");
            destroyer.output();

            Console.WriteLine("\n");

            PassangerLiner passangerLiner = new PassangerLiner();
            passangerLiner.input();
            Console.WriteLine("\n");

            passangerLiner.output();

            Console.ReadLine();
        }

    }
}
