using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lab03;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {

            //  1 Задание
            string[] months = {
                "June", "July", "August" , "September",
                "October", "November", "December", "January",
                "February", "March", "April", "May"
            };
            
            //StringFunctionCaller.StringFirstMethod(months);
            //StringFunctionCaller.StringSecondMethod(months);
            //StringFunctionCaller.StringThirdMethod(months);
            //StringFunctionCaller.StringFrthMethod(months);


            //  2 Задание
            List<House> houses = new List<House>()
            {
                new House {flatNumber = 1, flatArea = 10, flatFloor = 8, flatRoomQuant = 1, flatStreet = "test1", flatLifetime = DateTime.Now},
                new House {flatNumber = 2, flatArea = 12, flatFloor = 7, flatRoomQuant = 4, flatStreet = "test2", flatLifetime = DateTime.Now},
                new House {flatNumber = 3, flatArea = 10, flatFloor = 6, flatRoomQuant = 2, flatStreet = "Test1", flatLifetime = DateTime.Now},
                new House {flatNumber = 4, flatArea = 20, flatFloor = 5, flatRoomQuant = 1, flatStreet = "Test3", flatLifetime = DateTime.Now},
                new House {flatNumber = 5, flatArea = 10, flatFloor = 4, flatRoomQuant = 1, flatStreet = "Test1",flatLifetime = DateTime.Now},
                new House {flatNumber = 6, flatArea = 10, flatFloor = 3, flatRoomQuant = 3, flatStreet = "Test1", flatLifetime = DateTime.Now},
                new House {flatNumber = 7, flatArea = 11, flatFloor = 2, flatRoomQuant = 4, flatStreet = "EEEEE", flatLifetime = DateTime.Now},
                new House {flatNumber = 8, flatArea = 27, flatFloor = 1, flatRoomQuant = 3, flatStreet = "Tesst", flatLifetime = DateTime.Now}
            };

            //ListFunctionCaller.ListFirstFunction(houses);


            //  Задание 3

        }
    }
}
