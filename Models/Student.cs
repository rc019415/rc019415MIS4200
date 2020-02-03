using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rc019415MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }

        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
    }
}