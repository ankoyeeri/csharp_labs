using System;
using System.Collections.Generic;
using System.Text;

using Lab5.Construction;

namespace Lab5
{
    class ObjCaller : Printer
    {
        public static void Start()
        {
            DefShrub();
            DefFlower();
            DefRose();
            DefGladioulus();
            DefCactus();

            DefBouquet();

        }

        public static void CheckMethod()
        {
            Shrub shrub = new Shrub();
            shrub.Name = "Куст";
            shrub.Size = 50;

            Printer.IAmPrinting(shrub);

            Flower flower = new Flower();
            flower.Name = "Василек";
            flower.Size = 7;

            Printer.IAmPrinting(flower);

            Rose rose = new Rose();
            rose.Name = "Французская роза";
            rose.Size = 10.5;
            rose.Color = "Красный";
            
            Printer.IAmPrinting(rose);
        }

        public static void DefShrub()
        {
            Shrub shrub = new Shrub();
            shrub.Name = "Куст";
            shrub.Size = 50;
            Console.WriteLine($"Куст\nНазвание: {shrub.Name}\nРазмер: {shrub.Size}\n");
        }

        public static void DefFlower()
        {
            Flower flower = new Flower();
            flower.Name = "Василек";
            flower.Size = 7;
            Console.WriteLine($"Цветок\nНазвание: {flower.Name}\nРазмер: {flower.Size}\n");

        }

        public static void DefRose()
        {
            Rose rose = new Rose();
            rose.Name = "Французская роза";
            rose.Size = 10.5;
            rose.Color = "Красный";
            Console.WriteLine($"Роза\nНазвание: {rose.Name}\nРазмер: {rose.Size}\nЦвет: {rose.Color}\n");
        }

        public static void DefGladioulus()
        {
            Gladiolus gladiolus = new Gladiolus();
            gladiolus.Size = 12.2;
            Console.WriteLine($"Гладиолус\nНазвание: {gladiolus.Name}\nРазмер: {gladiolus.Size}\n");
        }

        public static void DefCactus()
        {
            Cactus cactus = new Cactus();
            cactus.Name = "Цереус";
            cactus.Size = 17.24;
            cactus.Difficulty = 3;
            Console.WriteLine($"Кактус\nНазвание: {cactus.Name}\nРазмер: {cactus.Size}\nСложность ухаживания: {cactus.DetectDifficulty(cactus.Difficulty)}");
        }

        public static void DefBouquet()
        {
            Bouquet bouquet1 = new Bouquet();

            //  вызов одноименных методов
            bouquet1.Note();
            ((IPaper)bouquet1).Note();

            bouquet1.Color = "Красный";
            bouquet1.Price = 17.4F;
            bouquet1.SeNumberOfFlowers(ref bouquet1.flowers, 3);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Цвет обертки букета: {bouquet1.Color}\nЦена букета: {bouquet1.Price}\n");
            int counter = 1;
            foreach (var flwr in bouquet1.flowers)
            {
                Console.WriteLine($"Цветок {counter++}\nНазвание цветка: {flwr.Name}\nРазмер цветка: {flwr.Size}\n");
            }
            Console.WriteLine("--------------------------------------");

            //Bouquet bouquet2 = new Bouquet();
            //bouquet2.Color = "Красный";
            //bouquet2.Price = 17.4F;
            //bouquet2.SeNumberOfFlowers(ref bouquet2.flowers, 1);
        }

        //  Работа с объектом через ссылку на интерфейс и абстрактный класс
        //  Работа is и as
        public static void ObjViaRefInterface()
        {
            IPaper paper = new Bouquet();
            paper.Color = "Зеленый";
            Console.WriteLine($"\nЦвет: {paper.Color}");
            paper.Note();

            Plant plant = new Bouquet();
            plant.Name = "Ромашка";
            Console.WriteLine($"\nНазвание: {plant.Name}");
            plant.Note();

            Plant plant1 = new Rose();
            plant1.Name = "Роза";
            plant1.Size = 2.43;
            Console.WriteLine($"\nНазвание: {plant1.Name}\nРазмер: {plant1.Size}");
            plant1.Note();
            Console.WriteLine($"{plant1.ToString()}");

            Flower flower = new Flower();
            Bouquet bouquet = new Bouquet();

            int num = 2;
            //bool checkFlower = flower is Flower;
            //bool checkBouquet = bouquet is Bouquet;
            //bool checkNum = num is Flower;

            bool checkFlower = bouquet is Flower;
            bool checkBouquet = flower is Bouquet;

            Console.WriteLine($"\ncheckFlower: {checkBouquet}\ncheckBouquet: {checkFlower}\ncheckNum:");


            try
            {
                Flower flower1 = new Flower();
                Rose rose = flower1 as Rose;
                Console.WriteLine($"\n{rose.GetType()}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }

            Rose rose1 = new Rose();
            Flower flower2 = rose1 as Flower;
            Console.WriteLine($"\n{flower2.GetType()}");
        }
    }
}
