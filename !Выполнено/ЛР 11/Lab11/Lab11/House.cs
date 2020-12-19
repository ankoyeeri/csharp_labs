using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Text;


//  Вариант 7
//  Создать класс House
//  Номер квартиры, Площадь, Этаж, Количество комнат, Улица, Тип здания
//  Срок эксплуатации

// Свойства и конструкторы должны обеспечивать проверку корректности
//  Добавить метод рассчета возраста здания (необходимость в кап. ремонте)

//  Создать массив объектов. Вывести:
//  Список квартир, имеющих заданное число комнат
//  Список квартир, имещющих заданное число комнат и расположенных
//  на этаже, который находится в заданном промежутке.
namespace Lab03
{
    class House
    {
        public int flatNumber { get; set; }             //  Номер квартиры
        public int flatArea { get; set; }               //  Площадь квартиры       
        public int flatFloor { get; set; }              //  Этаж квартиры
        public int flatRoomQuant { get; set; }          //  Количетво комнат квартиры
        public string flatStreet { get; set; }          //  Улица
        public string flatBuildingType { get; private set; }    //  Тип здания (ограничен доступ set)
        public DateTime flatLifetime { get; set; }    //  Срок эксплуатации

        //--------------
        public static string houseCountry = "Belarus";  //  Поле-константа

        public readonly int ID;     //  Поле для чтения
        //--------------

        public House()          //  Конструктор по умолчанию
        {
            flatNumber = 0;
            flatArea = 0;
            flatFloor = 0;
            flatRoomQuant = 0;
            flatStreet = "Не определено";
            flatBuildingType = "Не определено";
        }
        
        public House(int number, int floor)        //  Конструктор с двумя параметрами
        {
            flatNumber = number;
            flatFloor = floor;

            flatArea = flatRoomQuant = 0;
            flatStreet = flatBuildingType = null;

            flatLifetime = DateTime.MinValue;

            //  Генерация уникального номера (?)
            ID = number.GetHashCode() + floor.GetHashCode();
        }

        public House (int flatNumber, int flatArea, int flatFloor, int flatRoomQuant)   //  Конструктор с параметрами
        {
            this.flatNumber = flatNumber;
            this.flatArea = flatArea;
            this.flatFloor = flatFloor;
            this.flatRoomQuant = flatRoomQuant;
            this.flatStreet = null;
            this.flatBuildingType = null;

        }

        static House()          //  Статический конструктор (Предложить варианты его вызова)
        {
            Console.WriteLine("Создан класс с использованием статического класса\n");
        }
        
        //?????
       private House(int flatNumber, int flatArea, int flatFloor)
        {
            this.flatNumber = flatNumber;
            this.flatArea = flatArea;
            this.flatFloor = flatFloor;
        }   //  Закрытый конструктор
        //--------------

        public static void AgeOfHouse(ref DateTime dateOfBuild, DateTime flatLifetime, out bool result)
        {
            if(flatLifetime.Year - dateOfBuild.Year <= DateTime.Now.Year - dateOfBuild.Year )
            {
                result = false;     //  Дом в плохом состоянии
            }
            else
            {
                result = true;      //  Дом в нормальном состоянии
            }
        }

        //--------------
        //  Переопределение Equals
        public override bool Equals(object obj)
        {
            return obj is House house &&
                   flatNumber == house.flatNumber &&
                   flatArea == house.flatArea &&
                   flatFloor == house.flatFloor &&
                   flatRoomQuant == house.flatRoomQuant &&
                   flatStreet == house.flatStreet &&
                   flatBuildingType == house.flatBuildingType &&
                   flatLifetime == house.flatLifetime;
        }

        //  Переопределение GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(flatNumber, flatArea, flatFloor, flatRoomQuant, flatStreet, flatBuildingType, flatLifetime);
        }

        //  Переопределение ToString
        public override string ToString()
        {
            return $"Flat Number: {flatNumber}\nFlat Area: {flatArea}\n" +
                   $"Flat Floor: {flatFloor}\nFlat Room Quantity: {flatRoomQuant}" +
                   $"Flat Street: {flatStreet}\nFlat Building Type: {flatBuildingType}" +
                   $"Flat Life Time: {flatLifetime}\nID: {ID}";
        }
        //--------------

        ////--------------
        ////  Переопределение Equals
        //public override bool Equals(object? obj)
        //{
        //    if(obj == null)
        //    {
        //        return false;
        //    }

        //    House house = obj as House;

        //    if(house as House == null)
        //    {
        //        return false;
        //    }

        //    return house.flatNumber == this.flatNumber && house.flatFloor == this.flatFloor;
        //}
    }
}
