using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of football player:");
            int count = Convert.ToInt32(Console.ReadLine());

            Team team = new Team(count);

            for (int i = 0; i < count; i++)
            {
                team[i] = new Player();
                team[i].Name = Console.ReadLine();
                team[i].Number = Convert.ToInt32(Console.ReadLine());
            }

            Clear();

            Console.WriteLine("Your football team:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{team[i].Name} - {team[i].Number}");
            }

            Console.ReadKey();
        }

        public static void Clear()
        {
            Console.Clear();
        }

    }
}
