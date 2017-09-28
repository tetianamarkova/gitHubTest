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
