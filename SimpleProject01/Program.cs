﻿using System;
using System.Collections.Generic;
using ClassLibrary;
using System.Linq;

namespace SimpleProject01
{
    class Program
    {
        static List<Person> GetEmployees()
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

        static void Main(string[] args)
        {
            List<Person> employees = GetEmployees();

            bool EmployeeIsYoung(Person employee)
            {
                return employee.GetDateOfBirth() > new DateTime(2000, 1, 1);
            }
            List<Person> youngEmployees = employees.Where(EmployeeIsYoung).ToList();



            //foreach(var employee in employees)
            //{
            //    if (employee.GetDateOfBirth() > new DateTime(2000, 1, 1))
            //    {
            //        youngEmployees.Add(employee);
            //    }
            //}
            Console.WriteLine($"Young employees count: {youngEmployees.Count}");

            bool EmployIsBob(Person employee)
            {
                return employee.FirstName == "Bob";
            }

            Person bob = youngEmployees.FirstOrDefault(EmployIsBob);
            //Person bob = null;
            //foreach (Person youngEmployee in youngEmployees)
            //{
            //    if (youngEmployee.FirstName == "Bob")
            //    {
            //        bob = youngEmployee;
            //        break;
            //    }
            //}
            if (bob != null)
            {
                bob.SayHi();
            }
            else
            {
                Console.WriteLine("Bob not found");
            }

            ////LINQ
            
        }




        //static void DisplayElements(List<int> list)
        //{
        //    Console.WriteLine("** List **");
        //    foreach (int element in list)
        //    {
        //        Console.WriteLine($"{element}, ");
        //    }
        //    Console.WriteLine();
        //}

        //static void Main(string[] args)
        //{
        //    int[] numbers = { 3, 5, 6, 7, 8, 9, 0, 3 };
  
        //    foreach (int i in numbers)
        //    {
        //        List<int> intList = new List<int>();
        //        intList.Add(i);
        //        Console.WriteLine(i);
        //    }
        //    //DisplayElements(intList);


        //    List<int> intList = new List<int>();
        //    intList.Add(1);
        //    intList.Add(1);
        //    intList.Add(7);
        //    intList.Add(4);
        //    intList.Add(2);
        //    intList.Add(2);
        //    intList.Add(2);

        //    DisplayElements(intList);

        //    Console.WriteLine("New element");

        //    string inputValue = Console.ReadLine();
        //    int inputValueInt = int.Parse(inputValue);

        //    intList.Add(inputValueInt);

        //    DisplayElements(intList);

        //    //intList.RemoveRange(2, 3);

        //    intList.Sort();
        //    DisplayElements(intList);

        //    //Person bill = new Person("Bill", "Wick");
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
            ////}

            //int[] intArray = { 1, 2, 3, 4, 5 };
            //int arrayLenght = intArray.Length;
        //}

        
    }
}
