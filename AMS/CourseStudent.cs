﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS
{
    public class CourseStudent
    {
        public int CourseId { get; set; }

        public int UserId { get; set; }      

        public Course Course { get; set; }

        public User User { get; set; }
    }
}
