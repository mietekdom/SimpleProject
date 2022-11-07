using System;

namespace SimpleProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");
            //Person john = new Person(new DateTime(1990, 8, 2), "John", "Wick");

            bill.SetDateOfBirth(new DateTime(1990, 1, 2));


            bill.SayHi();

            Person john = new Person(new DateTime(1990, 8, 2), "John", "Wick");
            john.SayHi();
        }
    }
}
