using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise1.Codes;

internal struct AgeConverter
{
    public static double GetAge(DateTime dateOfBirth)
    {
        return Math.Round((DateTime.Now - dateOfBirth).TotalDays / 365.25, 2);
    }
}
