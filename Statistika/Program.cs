using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой на хората: ");
            int n = int.Parse(Console.ReadLine());
            People people = new People();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведи име и години на {i+1} човек: ");
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                people.AddMember(person);
            }

            people.Print();
        }
    }
}
