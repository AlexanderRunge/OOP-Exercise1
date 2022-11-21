using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1.Codes;
internal class Teacher
{
    public string? Department { get; set; }
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
    public Teacher(string? department, string? firstName, string? lastName, DateTime dateOfBirth)
    {
        Department = department;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}
