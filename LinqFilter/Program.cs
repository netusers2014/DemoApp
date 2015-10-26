using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFilter
{
    class Program
    {
        static void Main0(string[] args)
        {
            int[] Student = { 1, 2, 3, 4, 5, 10, 20, 40 };
            var select = from st in Student where st > 10 select st;
            //comment added for car
            foreach( var a in select)
            {
                System.Console.WriteLine(a);
            }
            Program.Display(lastname: "test", firstname: "first");
            System.Console.WriteLine(select.GetType().Name);
            System.Console.WriteLine(select.GetType().Namespace);
            Person p = new Person("Jon", "Mic");
            p.RegisterHander(p.LogUsername);
            // p.RegisterHander(p.LogUsername2);
            p.addPerson("1");
            Modifyname(p);
            System.Console.WriteLine(p.firstname);
            int? n = 10;
            int z = n ?? 20;
            System.Console.WriteLine("zzzz value" + z);
            if (n.HasValue)
                System.Console.WriteLine("Not null");
            else
                System.Console.WriteLine("Null");

        }
        public static void Display(String firstname, String lastname)
        {
            System.Console.WriteLine("Firstname" + firstname);
        }
        public static void Modifyname(Person per)
        {
            per.firstname = "0001";
            per = new Person("2000", "3000");
        }
    }

    class Person
    {
        public string firstname { set; get; }
        public string lastname {
            set; get; }

        public delegate void UserName(string name);
        private UserName UsernameHander;
        public void RegisterHander(UserName username )
        {
            UsernameHander += username;
        }

         public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
           
        }
        
        public void addPerson(String name)
        {
            UsernameHander(name);
        }

        public void LogUsername(string name)
        {
            System.Console.WriteLine("===================");
            System.Console.WriteLine("lOGuSERN" + name);
            System.Console.WriteLine("===================");
        }

        public void LogUsername2(string name)
        {
            System.Console.WriteLine("===================");
            System.Console.WriteLine("lOGuSERN2" + name);
            System.Console.WriteLine("===================");
        }

    }
}
