using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace rc019415MIS4200.Models
{
    public class Student
    {
        

        public int studentID { get; set; }

        public string fullName
        {
            get
            {
                return firstName + ", " + lastName;
            }
        }

        [Display(Name = "Student Last Name")]
        [Required(ErrorMessage = "last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Student First Name")]
        [Required(ErrorMessage = "first name is required")]
        [StringLength(20)]

        public string firstName { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }

        
        
    }
}