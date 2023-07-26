namespace EagerLoading.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}
