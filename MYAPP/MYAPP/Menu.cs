using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAPP
{
    class Menu
    {
        List<People> people;
        public Menu()
        {
            people = new List<People>();
        }
        public void Remove(People p)
        {
            people.Remove(p);
        }
        public void Print()
        {
            foreach(People p in people)
            {
                Console.WriteLine($"{p.Name} \t {p.PhoneNumber} \t {p.Address}");
            }
        }
    }
}
