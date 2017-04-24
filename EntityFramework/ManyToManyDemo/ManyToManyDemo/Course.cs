﻿using System.Collections;
using System.Collections.Generic;

namespace ManyToManyDemo
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}