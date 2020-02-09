using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rc019415MIS4200.Models
{
    public class Enrollment
    {
        [Key]
        public int enrollmentID { get; set; }
        public DateTime enrollmentDate { get; set; }
        public int studentID { get; set; }

        public virtual Student Student { get; set; }

        public int classId { get; set; }

        public virtual Classes Classes { get; set; }
    }
}