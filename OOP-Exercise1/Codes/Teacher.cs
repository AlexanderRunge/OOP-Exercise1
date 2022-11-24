using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1.Codes;
internal sealed class Teacher : Person
{
    public string? Department { get; set; }
    public Teacher(string? department, string? firstName, string? lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
    {
        Department = department;
    }
    public string returnDepartment()
    {
        return Department;
    }
    public override List<string> GetAllCourses(Enrollment enrollment)
    {
        List<string> Courses = new();
        foreach (var item in enrollment.Enrollments)
        {
            if (item.CourseInfo.TeacherInfo.FirstName == FirstName)
            {
                if (!Courses.Contains(item.CourseInfo.CourseName))
                {
                    Courses.Add(item.CourseInfo.CourseName);
                }
            }
        }
        return Courses;
    }

    public override List<string> GetAllCourses(List<Enrollment> enrollmentList)
    {
        List<string> Courses = new();
        foreach (var enrollment in enrollmentList)
        {
            foreach (var item in enrollment.Enrollments)
            {
                if (item.CourseInfo.TeacherInfo.FirstName == FirstName)
                {
                    if (!Courses.Contains(item.CourseInfo.CourseName))
                    {
                        Courses.Add(item.CourseInfo.CourseName);
                    }
                }
            }
        }
        return Courses;
    }
}