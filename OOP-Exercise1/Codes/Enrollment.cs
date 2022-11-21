using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1.Codes;
internal class Enrollment
{
    public Student StudentInfo { get; set; }
    public Course CourseInfo { get; set; }
    public Enrollment(Student studentInfo, Course courseInfo)
    {
        StudentInfo = studentInfo;
        CourseInfo = courseInfo;
    }
}
