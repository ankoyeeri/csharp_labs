using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class User : IEnumerable<User>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public string city;

        public User()
        {
            this.Name = null;
            this.Age = 0;
        }

        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private User(int age = 1)
        {
            this.Name = null;
            this.Age = age;
        }

        public static void ShowInfo(int a, string b, User user)
        {

        }

        public IEnumerator<User> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
