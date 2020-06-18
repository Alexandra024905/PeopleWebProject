using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleWebProject.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public int? Expеrience { get; set; }
    }
}