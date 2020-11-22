using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Lab03
{
    partial class House
    {
        public readonly int ID;
        int flatNumber;
        int flatArea;
        int flatFloor;
        int flatRooms;
        string flatStreet;
        string flatBuildingType;
        int flatSuitability;

        //------------------------
        public const string flatCountry = "Belarus";
        public static string test = "test";
        //------------------------

        //------------------------
        public int Number { get; set; }
        public int Area { get { return flatArea; } 
            set 
            {   if (value < 100)
                {
                    flatArea = value;
                }
                else
                {
                    Console.WriteLine("Недопустимое значение!");
                }
                    
            } 
        }
        public int Floor { get { return flatFloor; } set 
            { 
                if(value < 30)
                {
                    flatFloor = value;

                }
                else
                {
                    Console.WriteLine("Недопустимое значение!");
                }
            } 
        }
        public int Rooms { get { return flatRooms; } set { flatRooms = value; } }
        public  string Street { get { return flatStreet; } set { flatStreet = value; } }
        public string BuildingType { get { return flatBuildingType; } private set { flatBuildingType = value; } }
        public int Suitability { get { return flatSuitability; } set { flatSuitability = value; } }
        //-------------------------

        //-----------------------
        public static int counter = 0;
        public readonly int buffer;
        //-----------------------

        //------------------------
        public House(int flatNumber, int flatFloor)    //  конструктор с параметрами
        {
            this.flatNumber = flatNumber;
            this.flatFloor = flatFloor;

            int buffer = counter++;
        }
        public  House(int ID)
        {
            this.ID = ID;

            this.buffer = counter++;
        }


        public House(/*byte i = 1*/)                          //  конструктор с параметрами по умолчанию
        {
            ID = GetHashCode();

            flatNumber = 0;
            flatArea = 0;
            flatFloor = 0;
            flatRooms = 0;
            flatStreet = null;
            flatBuildingType = null;
            flatSuitability = 0;

            this.buffer = counter++;
        }

        static House()
        {
            Console.WriteLine($"Static constructor being used at {DateTime.Now}"); //  Статический конструктор
        }

        private House(int ID, int flatFloor, int flatRooms)
        {
            Console.WriteLine("Using private constructor");
        }
        //------------------------

        //-----------------------
        public static void CheckSuitability(ref int flatSuitableYear, out bool isSuitable)
        {
            int currentYear = 2020;
            isSuitable = false;

            if (flatSuitableYear > currentYear)
            {
                isSuitable = true;
            }
            if (flatSuitableYear <= currentYear)
            {
                isSuitable = false;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is House house &&
                   ID == house.ID &&
                   flatNumber == house.flatNumber &&
                   flatArea == house.flatArea &&
                   flatFloor == house.flatFloor &&
                   flatRooms == house.flatRooms &&
                   flatStreet == house.flatStreet &&
                   flatBuildingType == house.flatBuildingType &&
                   flatSuitability == house.flatSuitability &&
                   Number == house.Number &&
                   Area == house.Area &&
                   Floor == house.Floor &&
                   Rooms == house.Rooms &&
                   Street == house.Street &&
                   BuildingType == house.BuildingType &&
                   Suitability == house.Suitability &&
                   buffer == house.buffer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, flatNumber, flatArea, flatFloor, flatRooms, flatStreet, flatBuildingType, flatSuitability);
        }
        //-----------------------
    }
}
