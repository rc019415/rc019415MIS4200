﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rc019415MIS4200.Models
{
    public class Classes
    {
        public int classesId { get; set; }
        public string title { get; set; }

        public string description { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }

    }
}