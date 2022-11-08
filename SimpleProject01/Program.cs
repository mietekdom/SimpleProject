using System;
using System.Collections.Generic;
using ClassLibrary;

namespace SimpleProject01
{
    class Program
    {
        static void DisplayElements(List<int> list)
        {
            Console.WriteLine("** List **");
            foreach (int element in list)
            {
                Console.WriteLine($"{element}, ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(1);
            intList.Add(7);
            intList.Add(4);
            intList.Add(2);

            DisplayElements(intList);

            Console.WriteLine("New element");

            string inputValue = Console.ReadLine();
            int inputValueInt = int.Parse(inputValue);

            intList.Add(inputValueInt);

            DisplayElements(intList);

            //intList.RemoveRange(2, 3);

            intList.Sort();
            DisplayElements(intList);

            //Person bill = new Person("Bill", "Wick");
            //bill.SetDateOfBirth(new DateTime(1990, 1, 2));
            //bill.SayHi();

            //bill.ContactNumber = "58785";
            //if (bill.ContactNumber.Length > 9)
            //{
            //    Console.WriteLine("invalid number");
            //}
            //else
            //{
            //    Console.WriteLine(bill.ContactNumber);
            //}

            //Person john = new Person(new DateTime(1990, 8, 2), "John", "Wick");
            //john.SayHi();
            //Console.WriteLine($"Object of Person type count: {Person.Count}");

            //ExcelFile excelFile = new ExcelFile();
            //excelFile.CreatedOn = DateTime.Now;
            //excelFile.FileName = "excel-file";
            //excelFile.GenerateReport();

            //WordDocumentFile wordDocumentFile = new WordDocumentFile();
            //wordDocumentFile.CreatedOn = DateTime.Now;
            //wordDocumentFile.FileName = "word-file";
            //wordDocumentFile.Print();

            //Class1 test = new Class1();
            //test.PublicProp = "test";

            //Shape[] shapes = { new Circel(), new Rectangle(), new Triangle() };

            //foreach(Shape shape in shapes)
            //{
            //    shape.Draw();
            //}

            int[] intArray = { 1, 2, 3, 4, 5 };
            int arrayLenght = intArray.Length;
        }

        
    }
}
