﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Xml.Linq;

namespace Algorithms
{
    class LINQ
    {
        // Specify the data source.
        public static int[] scores = new int[] {
            97, 92, 81, 60, 53,
            37, 32, 31, 30, 33,
            91, 90, 84, 66, 73,
            99, 42, 21, 60, 75,
            17, 12, 61, 80, 65
        };
        public static string[] words = {
            "Hello", "Wonderful", "LINQ", "beautiful", "world",
            "Hello World!", "Wonderfull Experience", "LINQ is Amazing", "A", "B",
            "My name is Rahul Vats", "1", "2", "A", "B",
            "Rahul Vats", "1Number", "2Number", "ANumber", "BNumber",
            "Test", "Number1", "Number2", "NumberA", "NumberB",
        };
        public static void TestLinq()
        {
            //Get only short words
            var shortWords = from word in words
                             where word.Length <= 5
                             select word;

            //Print each word out
            foreach (string word in shortWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }

        public static void TestLinqQuery()
        {
            //Get Long words
            var longwords = from w in words where w.Length > 10 select w;

            //Print each word out
            foreach (string word in longwords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }

        public static void TestLinqLambda()
        {
            //Get Words with Precise Length
            IEnumerable<string> Words = words.Where(w => w.Length == 5);
            //Print each word out
            foreach (string word in Words)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }

        public static void TestLinqEnumerable()
        {
            // Define the query expression.
            IEnumerable<int> scoreQuery = from score in scores
                                          where score > 80
                                          select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }

        public static void TestLINQXML()
        {
            string myXML = @"<Departments>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        //public static void LINQInsert()
        //{
        //    string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQDBConnectionString"].ToString();

        //    DataContext db = new DataContext(connectString);

        //    //Create new Employee
        //    Employee newEmployee = new Employee();
        //    newEmployee.Name = "Michael";
        //    newEmployee.Email = "yourname@companyname.com";
        //    newEmployee.ContactNo = "343434343";
        //    newEmployee.DepartmentId = 3;
        //    newEmployee.Address = "Michael - USA";

        //    //Add new Employee to database
        //    db.Employees.InsertOnSubmit(newEmployee);

        //    //Save changes to Database.
        //    db.SubmitChanges();

        //    //Get new Inserted Employee            
        //    Employee insertedEmployee = db.Employees.FirstOrDefault(e => e.Name.Equals("Michael"));

        //    Console.WriteLine("Employee Id = {0} , Name = {1}, Email = {2}, ContactNo = {3}, Address = {4}",
        //                      insertedEmployee.EmployeeId, insertedEmployee.Name, insertedEmployee.Email,
        //                      insertedEmployee.ContactNo, insertedEmployee.Address);

        //    Console.WriteLine("\nPress any key to continue.");
        //    Console.ReadKey();
        //}
    }
}
//At the end of each file there are sample use cases which can be entered into the main program to run the code.
/*
 * LINQ.TestLinq();
            LINQ.TestLinqQuery();
            LINQ.TestLinqLambda();
            LINQ.TestLinqEnumerable();
            LINQ.TestLINQXML();
            
 */
