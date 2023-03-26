using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.name = "Pesho";
            person2.name = "Gosho";
            person3.name = "Stamat";

            person1.age = 20;
            person2.age = 18;
            person3.age = 43;

            Console.WriteLine($"Name: {person1.name} Age: {person1.age}");
            Console.WriteLine($"Name: {person2.name} Age: {person2.age}");
            Console.WriteLine($"Name: {person3.name} Age: {person3.age}");

            //Type personType = typeof(Person);
            //FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            //Console.WriteLine(fields.Length);
        }
    }
}
