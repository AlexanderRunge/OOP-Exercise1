using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1.Codes;

internal abstract class Person
{
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

    public Person(string? firstName, string? lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public int returnAge()
    {
        return Age;
    }

    public virtual string returnFullName()
    {
        return LastName + ", " + FirstName;
    }

    public abstract List<String> GetAllCourses(Enrollment enrollment);
    public abstract List<String> GetAllCourses(List<Enrollment> enrollment);
}