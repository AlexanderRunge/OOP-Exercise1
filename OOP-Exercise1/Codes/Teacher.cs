using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1.Codes;
sealed class Teacher : Person
{
    public string? Department { get; set; }
    public Teacher(string? department, string? firstName, string? lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
    {
        Department = department;
    }
}