using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProject01
{
    class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Constructor 1");
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            Console.WriteLine("Constructor 2");
            SetDateOfBirth(dateOfBirth);
            FirstName = firstName;
            LastName = lastName;
        }

        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date");
            }
            else
            {
                dateOfBirth = date;
            }
        }

        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Hi, Im {FirstName}, {GetDateOfBirth()}");
        }
    }
}
