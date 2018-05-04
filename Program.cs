using System;
using System.Collections.Generic;


namespace ques3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> objList = new List<Person>();
            char choice = 'y';
            string Fname, Lname;
            int YearOfBirth;
            int count = 0;
            while (choice == 'y')
            {
                Console.WriteLine("Enter name of new person below");
                Console.Write("First Name: ");
                Fname = (Console.ReadLine());
                Console.Write("Last Name: ");
                Lname = (Console.ReadLine());
                Person person = new Person(Fname, Lname);
                Console.WriteLine("\r\nCreating new person record");
                Console.Write("\r\nEnter Year Of Birth: ");
                YearOfBirth = Int32.Parse((Console.ReadLine()));
                person.YearOfBirth = YearOfBirth;
                objList.Add(person);
                string desc = "\r\nPerson: " + objList[count].GetFullName() + " is " + objList[count].GetAge() + " years old";
                Console.WriteLine(desc);
                Console.Write("Do you want to enter another person? <y/n> ");
                choice = char.Parse(Console.ReadLine());
                count++;
            }
 
            Console.ReadKey();
        }
    }
}
