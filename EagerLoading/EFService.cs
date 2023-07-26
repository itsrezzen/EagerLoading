using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EagerLoading
{
    public class EFService
    {
        private readonly MyDbContext _dbContext;

        public EFService(
            MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void PrintTeachersWithCoursesAndTags()
        {
            var result = _dbContext.TeacherCourses
                .Include(x => x.Course)
                .ThenInclude(x => x.Tags)
                .Include(x => x.Teacher)
                .ToList();

            foreach (var teacherCourse in result)
            {
                Console.WriteLine("The Teacher Name Is : " + teacherCourse.Teacher.FirstName + " " + teacherCourse.Teacher.LastName + " And The Course Is : " + teacherCourse.Course.Title);
                foreach (var courseTag in teacherCourse.Course.Tags)
                {
                    Console.WriteLine("Tag Title Is : " + courseTag.Title);
                }
            }
        }
    }
}
