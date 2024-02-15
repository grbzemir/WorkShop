using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop1.Entities.Concrete
{
    public class Course:BasePerson
    {

        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string ImagePath { get; set; }
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public int CourseProces { get; set; }
    }
}
