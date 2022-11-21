using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1.Codes;

internal class Student
{
    public int? StudentID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime _DateOfBirth { get; set; }

    public DateTime DateOfBirth
    {
        get { return _DateOfBirth; }
        set
        {
            _DateOfBirth = value;
            Age = (int)AgeConverter.GetAge(_DateOfBirth);
        }
    }

    public int Age { get; set; }
    public Student(int? studentID, string? firstName, string? lastName, DateTime dateOfBirth)
    {
        StudentID = studentID;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}