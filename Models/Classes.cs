using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace rc019415MIS4200.Models
{
    public class Classes
    {
       

        [Display(Name = "Professor First Name")]
        [Required(ErrorMessage ="first name is required")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Display(Name = "Professor Last Name")]
        [Required(ErrorMessage = "last name is required")]
        [StringLength(20)]
        public string LastName { get; set; }

        
        public int classesId { get; set; }
        [Display (Name = "Title")]
        [Required(ErrorMessage = "Title is required")]
        [StringLength(20)]

        public string title { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(150)]
        public string description { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }

    }
}