using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    internal class People
    {
        public List<Person> people = new List<Person>();

        public void AddMember(Person person)
        {
            if (person.age >= 30)
            {
                people.Add(person);
            }
        }

        public void Print()
        {
            foreach (Person member in people)
            {
                Console.WriteLine($"Име: {member.name} Години: {member.age}");
            }
        }
    }
}
