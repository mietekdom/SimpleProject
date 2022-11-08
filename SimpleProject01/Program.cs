using System;
using ClassLibrary;

namespace SimpleProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");
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
            Console.WriteLine($"Object of Person type count: {Person.Count}");

            ExcelFile excelFile = new ExcelFile();
            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel-file";
            excelFile.GenerateReport();

            WordDocumentFile wordDocumentFile = new WordDocumentFile();
            wordDocumentFile.CreatedOn = DateTime.Now;
            wordDocumentFile.FileName = "word-file";
            wordDocumentFile.Print();

            Class1 test = new Class1();
            test.PublicProp = "test";

        }
    }
}
