using System.Collections.Generic;

namespace CourseApp.Models // namespace projedeki bütün kodların classların bulunduğu yer
{
    public static class Repository // bu bir veritabanı rolünü üslenicek o yüzden static
    {
        
        private static List<Student> _students = new List<Student>();

        // Repository.Students
        public static List<Student> Students
        {
            get
            {
                return _students;
            }
        }

        // Repository.AddStudent(student);
        public static void AddStudent(Student student)
        {
            _students.Add(student);
        }
    }


}