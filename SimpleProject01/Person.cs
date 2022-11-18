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
        public string ContactNumber { get; set;}

        public static int Count = 0;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Count++;
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
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
