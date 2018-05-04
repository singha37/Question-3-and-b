using System;
using System.Collections.Generic;


namespace ques3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        public string GetFullName()
        {
            string FullName = FirstName + " " + LastName;
            return FullName;
        }

        public int GetAge()
        {
            return (2018 - YearOfBirth);
        }
    }

}
