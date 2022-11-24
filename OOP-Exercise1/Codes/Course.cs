using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1.Codes;

internal class Course
{
    public string? CourseName { get; set; }
    public Teacher? TeacherInfo { get; set; }

    public Course(string courseName, Teacher teacherInfo)
    {
        CourseName = courseName;
        TeacherInfo = teacherInfo;
    }
    public List<string> GetAllStudents(Enrollment enrollment)
    {
        List<string> Students = new();
        foreach (var item in enrollment.Enrollments)
        {
            if (item.CourseInfo.CourseName == CourseName)
            {
                string student = $"{item.StudentInfo.FirstName} {item.StudentInfo.LastName}";
                if (!Students.Contains(student))
                {
                    Students.Add(student);
                }
            }
        }
        return Students;
    }
    public void CourseStudentAmount(Enrollment enrollment)
    {
        List<string> Students = GetAllStudents(enrollment);
        if (Students.Count < 8)
        {
            throw new Exception($"{CourseName} har mindre en 8 studenter");
        }
        else if (Students.Count > 16)
        {
            throw new Exception($"{CourseName} har mere en 16 studenter");
        }
    }
}
