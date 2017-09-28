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
