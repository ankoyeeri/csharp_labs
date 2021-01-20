using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

using Lab14.Construction;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouquet bouquet = new Bouquet();
            bouquet.Color = "Red";
            bouquet.Price = 27F;

            #region Task 1

            #region Binary Serialization
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
            Console.WriteLine("Бинарная десериализация объекта из файла завершена\n");
            #endregion

            #region SOAP Serialization
            //  SOAP сереализация
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
            Console.WriteLine("SOAP десереализаця завершена\n");
            #endregion

            #region XML Serialization
            //  XML сериализация 
            XmlSerializer xml = new XmlSerializer(typeof(Bouquet));
            using (FileStream fs = new FileStream("XMLFile.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, bouquet);
            }
            Console.WriteLine("XML сериализация завершена");

            using (FileStream fs = new FileStream("XMLFile.xml", FileMode.Open))
            {
                Bouquet newBouquet = (Bouquet)xml.Deserialize(fs);
                Console.WriteLine(newBouquet.ToString());
            }
            Console.WriteLine("XML десереализация завершена\n");
            #endregion

            #region JSON Serialization
            //  JSON сериализация
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Bouquet));
            using (FileStream fs = new FileStream("JSONFile.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(fs, bouquet);
            }
            Console.WriteLine("JSON сериализация завершена");

            using (FileStream fs = new FileStream("JSONFile.json", FileMode.Open))
            {
                Bouquet newBouquet = (Bouquet)json.ReadObject(fs);
                Console.WriteLine(newBouquet.ToString());
            }
            Console.WriteLine("JSON десериализация завершена\n");
            #endregion

            #endregion

            #region Task 2
            //  Задание 2
            List<Bouquet> bouquets = new List<Bouquet>()
            {
                new Bouquet{ Color = "Green", Price = 46F},
                new Bouquet{ Color = "Yellow", Price = 25F},
                new Bouquet{ Color = "Blue", Price = 11F},
            };

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Bouquet>));
            using (FileStream fs = new FileStream("JSONFileCollection.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, bouquets);
            }
            Console.WriteLine("JSON сериализация коллекции  завершена");

            using (FileStream fs = new FileStream("JSONFileCollection.json", FileMode.Open))
            {
                List<Bouquet> newBouquets = (List<Bouquet>)jsonSerializer.ReadObject(fs);
                

                foreach(var item in newBouquets)
                {
                    Console.WriteLine($"{nameof(item.Color)}: {item.Color}");
                    Console.WriteLine($"{nameof(item.Price)}: {item.Price}");
                }
            }
            Console.WriteLine("JSON десериализация коллекции завершена\n");
            #endregion

            #region Task 3

            Console.WriteLine("Task 3");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("XMLFile.xml");
            XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode("Color");

            Console.WriteLine($"Color: {xmlNode.InnerText}");

            #endregion

            #region Task 4
            Console.WriteLine("\nTask 4. Создание XML документа.");

            XDocument xdoc = new XDocument(new XElement("xml",
                             new XElement("University",
                                    new XElement("Name", "БГТУ"),
                                    new XElement("Capacity", "10000"),
                                    new XElement("City", "Минск")),
                             new XElement("University",
                                    new XElement("Name", "БГУИР"),
                                    new XElement("Capacity", "15000"),
                                    new XElement("City", "Минск")),
                             new XElement("University",
                                    new XElement("Name", "ГрГу"),
                                    new XElement("Capacity", "5000"),
                                    new XElement("City", "Гродно"))));
            xdoc.Save("NewXML.xml");
            Console.WriteLine("XML документ создан\n");


            Console.WriteLine("Начало чтения XML документа");
            xdoc = XDocument.Load("NewXML.xml");
            foreach(XElement element in xdoc.Element("xml").Elements("University"))
            {
                Console.WriteLine($"Name: {element.Element("Name").Value}");
                Console.WriteLine($"Capacity: {element.Element("Capacity").Value}");
                Console.WriteLine($"City: {element.Element("City").Value}\n");
            }

            Console.WriteLine("Поиск по городу Гродно");
            var requestCity = from x in xdoc.Element("xml").Elements("University")
                              where x.Element("City").Value == "Гродно"
                              select new
                              {
                                  Name = x.Element("Name").Value,
                                  City = x.Element("City").Value
                              };

            foreach(var item in requestCity)
            {
                Console.WriteLine($"{item.Name}\t{item.City}");
            }

            Console.WriteLine("\nВместимость не меньше 10000");
            var requestCapacity = from x in xdoc.Element("xml").Elements("University")
                                  where Convert.ToInt32(x.Element("Capacity").Value) >= 10000
                                  select new
                                  {
                                      Name = x.Element("Name").Value,
                                      Capacity = x.Element("Capacity").Value
                                  };

            foreach (var item in requestCapacity)
            {
                Console.WriteLine($"{item.Name}\t{item.Capacity}");
            }
            #endregion
        }
    }
}
