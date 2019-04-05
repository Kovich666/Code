using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateANDEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Eugeni"
            };


            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("02.04.2019 11:29:01"));
            person.TakeTime(DateTime.Parse("02.04.2019 04:02:01"));
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} is working");
            }
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Human is going to sleep");
            Console.ReadLine();
        }
    }
}
