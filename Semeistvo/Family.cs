using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semeistvo
{
    public class Family
    {
        public List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            members.Add(person);
        }
        public void Print()
        {
            foreach (Person member in members)
            {
                Console.WriteLine($"Име: {member.name} Години: {member.age}");
            }
        }
    }
}
