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

            bill.ContactNumber = "58785";
            if (bill.ContactNumber.Length > 9)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine(bill.ContactNumber);
            }

            Person john = new Person(new DateTime(1990, 8, 2), "John", "Wick");
            john.SayHi();
        }
    }
}
