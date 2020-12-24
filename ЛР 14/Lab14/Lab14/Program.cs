using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

using Lab14.Construction;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouquet bouquet = new Bouquet("Red",27F);

            BinaryFormatter binary = new BinaryFormatter();
            //  Бинарная сериализация в файл  
            using (FileStream fs = new FileStream("BinaryFile.txt", FileMode.OpenOrCreate))
            {
                binary.Serialize(fs, bouquet);
            }
            Console.WriteLine("Бинарная сериализация объекта в файл завершена");

            //  Бинарная десерализация из файла
            using(FileStream fs = new FileStream("BinaryFile.txt", FileMode.Open))
            {
                Bouquet newBouquet = (Bouquet)binary.Deserialize(fs);
                Console.WriteLine(newBouquet.ToString());
            }
            Console.WriteLine("Бинарная десериализация объекта из файла завершена");


            SoapFormatter soap = new SoapFormatter();
            using (FileStream fs = new FileStream("SoapFile.soap", FileMode.OpenOrCreate))
            {
                soap.Serialize(fs, bouquet);
            }
            Console.WriteLine("SOAP сериализаця завершена");

            using (FileStream fs = new FileStream("SoapFile.soap", FileMode.Open))
            {
                Bouquet newBouquet = (Bouquet)soap.Deserialize(fs);
                Console.WriteLine(newBouquet.ToString());
            }
            Console.WriteLine("SOAP десереализаця завершена");


            XmlSerializer xml = new XmlSerializer(typeof(Bouquet));
            using(FileStream fs = new FileStream("XMLFile.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, xml);
            }
            Console.WriteLine("XML сериализация завершена");

            using (FileStream fs = new FileStream("XMLFile.xml", FileMode.Open))
            {
                Bouquet newBouquet = (Bouquet)xml.Deserialize(fs);
                Console.WriteLine(newBouquet.ToString());
            }
            Console.WriteLine("XML десереализация завершена");


        }
    }
}
