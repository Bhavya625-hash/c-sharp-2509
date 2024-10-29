using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class university
    {
        private List<Department> departments = new List<Department>();
    

       
         // Method to add a department to the university
        public void AddDepartment(string name)
        {
            var department = new Department(name);
            departments.Add(department);
            Console.WriteLine($"Added department: {name}");
        }

        // Method to add a course to a department
        public void AddCourse(string departmentName, string courseName, string courseCode, int credits)
        {
            var department = departments.Find(d => d.Name == departmentName);
            if (department != null)
            {
                department.AddCourse(courseName, courseCode, credits);
            }
            else
            {
                Console.WriteLine($"Department {departmentName} not found.");
            }
        }

        // Method to display all course details
        public void DisplayCourseDetails()
        {
            foreach (var department in departments)
            {
                Console.WriteLine($"\nDepartment: {department.Name}");
                department.DisplayCourses();
            }
        }

        // Nested Department class
        public class Department
        {
            public string Name { get; set; }
            private List<Course> courses;

            // Constructor for Department
            public Department(string name)
            {
                Name = name;
                courses = new List<Course>();
            }

            // Method to add a course to the department
            public void AddCourse(string courseName, string courseCode, int credits)
            {
                var course = new Course(courseName, courseCode, credits);
                courses.Add(course);
                Console.WriteLine($"Added course {courseName} to department {Name}");
            }

            // Method to display courses of the department
            public void DisplayCourses()
            {
                if (courses.Count == 0)
                {
                    Console.WriteLine("No courses found.");
                    return;
                }

                foreach (var course in courses)
                {
                    Console.WriteLine($"Course Name: {course.CourseName}, Course Code: {course.CourseCode}, Credits: {course.Credits}");
                }
            }

            // Nested Course class
            public class Course
            {
                public string CourseName { get; set; }
                public string CourseCode { get; set; }
                public int Credits { get; set; }

                // Constructor for Course
                public Course(string courseName, string courseCode, int credits)
                {
                    CourseName = courseName;
                    CourseCode = courseCode;
                    Credits = credits;
                }
            }
        }
    }
}
