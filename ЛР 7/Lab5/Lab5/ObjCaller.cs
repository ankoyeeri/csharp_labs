using Lab5.Construction;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Проверка метода <c><see cref="Printer.IAmPrinting(Plant)"/></c>
        /// </summary>
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
            rose.Color = (Colors)1;

            Printer.IAmPrinting(rose);
        }

        /// <summary>
        /// Конструктор класса <see cref="Shrub"/>
        /// </summary>
        public static void DefShrub()
        {
            Shrub shrub = new Shrub();
            shrub.Name = "Куст";
            shrub.Size = 50;
            Console.WriteLine($"Куст\nНазвание: {shrub.Name}\nРазмер: {shrub.Size}\n");
        }

        /// <summary>
        /// Конструктор класса <see cref="Flower"/>
        /// </summary>
        public static void DefFlower()
        {
            Flower flower = new Flower();
            flower.Name = "Василек";
            flower.Size = 7;
            Console.WriteLine($"Цветок\nНазвание: {flower.Name}\nРазмер: {flower.Size}\n");

        }

        /// <summary>
        /// Конструктор класса <see cref="Rose"/>
        /// </summary>
        public static void DefRose()
        {
            Rose rose = new Rose();
            rose.Name = "Французская роза";
            rose.Size = 10.5;
            rose.Color = (Colors)1;
            Console.WriteLine($"Роза\nНазвание: {rose.Name}\nРазмер: {rose.Size}\nЦвет: {rose.Color}\n");
        }
        
        /// <summary>
        /// Конструктор класса <see cref="Gladiolus"/>
        /// </summary>
        public static void DefGladioulus()
        {
            Gladiolus gladiolus = new Gladiolus();
            gladiolus.Size = 12.2;
            Console.WriteLine($"Гладиолус\nНазвание: {gladiolus.Name}\nРазмер: {gladiolus.Size}\n");
        }

        /// <summary>
        /// Конструктор класса <see cref="Cactus"/>
        /// </summary>
        public static void DefCactus()
        {
            Cactus cactus = new Cactus();
            cactus.Name = "Цереус";
            cactus.Size = 17.24;
            cactus.Difficulty = 3;
            Console.WriteLine($"Кактус\nНазвание: {cactus.Name}\nРазмер: {cactus.Size}\nСложность ухаживания: {cactus.DetectDifficulty(cactus.Difficulty)}");
        }

        /// <summary>
        /// Конструктор класса <see cref="Bouquet"/>
        /// </summary>
        public static void DefBouquet()
        {
            Bouquet bouquet1 = new Bouquet();
            int counter = 0;

            //  вызов одноименных методов
            //bouquet1.Note();
            //((IPaper)bouquet1).Note();

            ((IPaper)bouquet1).Color = "Красный";
            bouquet1.Price = 17.4F;
            bouquet1.Flowers = new List<Flower>();
            bouquet1.Flowers.AddFlower();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Цвет обертки букета: {bouquet1.Color}\nЦена букета: {bouquet1.Price}\n");
            foreach(var flower in bouquet1.Flowers)
            {
                Console.WriteLine($"{counter}) {flower.Name}    {flower.Size}   {flower.Color}");
                counter++;
            }
            Console.WriteLine("--------------------------------------");

            
            bouquet1.Flowers.DeleteFlower();
        }

        /// <summary>
        ///  <para>Работа с объектом через ссылку на интерфейс и абстрактный класс</para>
        ///  <para>Работа is и as</para>
        /// </summary>
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

        /// <summary>
        /// Сортировки листа
        /// </summary>
        public static void CallSort()
        {
            Bouquet bouquet = new Bouquet();
            ((IPaper)bouquet).Color = "Красный";
            bouquet.Price = 16.26F;
            bouquet.Flowers = new List<Flower>()
            {
                new Flower { Name = "Цветок 1", Color = (Colors)2, Size = 5},
                new Flower { Name = "Цветок 2", Color = (Colors)2, Size = 4},
                new Flower { Name = "Цветок 3", Color = (Colors)3, Size = 3},
                new Flower { Name = "Цветок 4", Color = (Colors)4, Size = 2},
                new Flower { Name = "Цветок 5", Color = (Colors)5, Size = 1}
            };

            BouquetController.SortListByParam(bouquet);
            BouquetController.FindByColor(bouquet);
        }
    }
}
