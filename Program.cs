using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(customer));
            TextReader reader = new StreamReader("D:\\6520502057\\labSoa\\lab2\\customer-jaxb.xml");
            customer po = (customer)serializer.Deserialize(reader);

            Console.WriteLine(po.name);
            foreach(phoneNumber p in po.phonenumber)
            {
                Console.WriteLine(p.number);
            }

            Console.Read();

        }
    }
}
