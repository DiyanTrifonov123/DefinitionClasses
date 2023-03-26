using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semeistvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи броя на семейството: ");
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведи име и години на {i+1} член на семейството: ");
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }
            family.Print();
        }
    }
}
