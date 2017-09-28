using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
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

        public void Add()
        {
            People p = new People();
            Console.WriteLine("Input Name -> ");
            p.Name = Console.ReadLine();
            Console.WriteLine("Input PhoneNumber -> ");
            p.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Input Address -> ");
            p.Address = Console.ReadLine();
            people.Add(p);
            Console.WriteLine("Person is added");
        }
        public void Sort()
        {
            people.Sort();
            foreach (var p in people)
                Console.WriteLine(p);
        }
        public void Remove()
        {
            Print();
            Console.WriteLine("Input index -> ");
            int i = Convert.ToInt32(Console.ReadLine());
            people.RemoveAt(i - 1);
            Console.WriteLine($"Persone is removed");
        }
        public void Print()
        {
            int i = 1;
            foreach (People p in people)
            {
                Console.WriteLine($"{i} {p.Name} \t {p.PhoneNumber} \t {p.Address}");
                i++;
            }
        }

        public void SaveToFile()
        {
            using (FileStream fs =
                new FileStream("PhoneBookXML.xml", FileMode.Create))
            {
                SoapFormatter xs = new SoapFormatter();
                xs.Serialize(fs, people);
            }
            Console.WriteLine("Saved to PhoneBook");
        }
        public void LoadFromFile()
        {
            using (FileStream fs =
                new FileStream("PhoneBookXML.xml", FileMode.Open))
            {
                SoapFormatter xs = new SoapFormatter();
                people = (List<People>)xs.Deserialize(fs);
            }
            Console.WriteLine("Loaded from PhoneBook");


        }
    }
}
