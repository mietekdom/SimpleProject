using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject01
{
    public class Lambda
    {
        private static List<Person> LambdaTest()
        {
            List<Person> employees = new List<Person>()
            {
                new Person(new DateTime(1990, 1, 13), "Bill", "The Kid"),
                new Person(new DateTime(1987, 9, 30), "John", "Kowalsky"),
                new Person(new DateTime(2012, 2, 23), "Mitson", "Rebec"),
                new Person(new DateTime(1982, 12, 6), "William", "Dom"),
                new Person(new DateTime(1994, 7, 8), "Samanta", "Black"),
                new Person(new DateTime(2001, 5, 14), "Ed", "Smyth"),
                new Person(new DateTime(2008, 4, 10), "Bob", "Wick")    
            };
            return employees;
        }

        public void CheckPerson()
        {

            List<Person> employees = LambdaTest();

            List<Person> youngEmployees = employees.Where(e => e.GetDateOfBirth() > new DateTime(1995, 1, 1)).ToList();

            Console.WriteLine($"Young employees count: {youngEmployees.Count}");

            Person bob = youngEmployees.FirstOrDefault(e => e.FirstName == "Bob");

            if (bob != null)
            {
                bob.SayHi();
            }
            else
            {
                Console.WriteLine("Bob not found");
            }
        }
    }
}
