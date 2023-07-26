using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagerLoading.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public ICollection<TeacherCourse> TeacherCourses { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
