using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPuc.Models
{
    public class Student
    {
        public Student(string Name, string Age, string Country, string City)
        {
            this.Name = Name;
            this.Age = Age;
            this.Country = Country;
            this.City = City;
        }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
    }
}