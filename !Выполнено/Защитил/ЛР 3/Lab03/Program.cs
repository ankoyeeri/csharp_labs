using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(1, 11);
            House house2 = new House(1,11);
            
            //----------
            //  Проверка переопределенных методов
            Console.WriteLine(house1.Equals(house2)+"\n");
            Console.WriteLine(house1.ToString());
            Console.WriteLine(house1.GetHashCode());

            //----------


            //----------
            //  Проверка ref и out
            house1.flatLifetime = new DateTime(2040, 4, 10);
            DateTime dateofBuild = new DateTime(1900, 11, 26);
            House.AgeOfHouse(ref dateofBuild , house1.flatLifetime, out bool result);   //  использование ref и out

            if(result == true)
            {
                Console.WriteLine("Дом в нормальном состоянии\n");
            }
            else
            {
                Console.WriteLine("Дом нуждается в капитальном ремонте\n");
            }
            //----------

            //----------
            //  Проверка partial классов
            PartialClassExample.FirstAction();
            PartialClassExample.SecondAction();
            //----------

            //----------
            //  Проверка ID
            Console.WriteLine(house1.ID);
            Console.WriteLine(house2.ID);
            //----------
            Console.ReadLine();
        }
    }
}




