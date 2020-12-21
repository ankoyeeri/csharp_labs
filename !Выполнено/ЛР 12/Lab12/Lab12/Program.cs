using System;

using System.Reflection;
using System.Threading;
using System.Reflection.Emit;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Alex";
            user.Age = 20;

            Reflector.GetAssemblyBuild(user);
            Reflector.CheckPublicConstructors(user);
            Reflector.GetPublicPublicMethods(user);
            Reflector.GetPublicFieldProperties(user);
            Reflector.GetRealisedInterfaces(user);
            Reflector.SearchMethodByParameterType(user, typeof(string).Name);

            object[] parms = { "name", 2 };
            User newObj = (User)Reflector.Create(user, parms);
            
            Console.WriteLine($"Name: {newObj.Name}\nAge: {newObj.Age}");
        }
    }
}
