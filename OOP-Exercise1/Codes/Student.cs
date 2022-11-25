using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1.Codes;

internal sealed class Student : Person
{
    public int? StudentID { get; set; }
    public Student(int studentID, string? firstName, string? lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
    {
        StudentID = studentID;
    }

    public override List<string> GetAllCourses(Enrollment enrollment)
    {
        List<string> Courses = new();
        foreach (var item in enrollment.Enrollments)
        {
            if (item.StudentInfo.StudentID == StudentID)
            {
                if (!string.IsNullOrEmpty(item.CourseInfo.CourseName))
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
    public override List<string> GetAllCourses(List<Enrollment> enrollmentList)
    {
        List<string> Courses = new();
        foreach (var enrollment in enrollmentList)
        {
            foreach (var item in enrollment.Enrollments)
            {
                if (item.StudentInfo.StudentID == StudentID)
                {
                    if (!string.IsNullOrEmpty(item.CourseInfo.CourseName))
                    {
                        if (!Courses.Contains(item.CourseInfo.CourseName))
                        {
                            Courses.Add(item.CourseInfo.CourseName);
                        }
                    }
                }
            }
        }
        return Courses;
    }

    public override string returnFullName()
    {
        return FirstName + " " + LastName;
    }
}