using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAPP
{
    class Menu
    {
        //list
        //add

        List<People> people;
        public Menu()
        {
            people = new List<People>();
        }
        public void Add(People p)
        {
            people.Add(p);
        }
        public void Sort()
        {
            people.Sort();
            foreach (var p in people)
                Console.WriteLine(p);
        }
    }
}
