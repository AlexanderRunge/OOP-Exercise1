using System.Net.NetworkInformation;
using EnumCourses = OOP_Exercise1.Codes.EnumCourses;

Teacher Niels = new("Programmering", "Niels", "Olesen", new DateTime(1972, 9, 11));

Course Studieteknik = new(Courses.Studieteknik.ToString(), Niels);
Course Grundprog = new(Courses.Grundprog.ToString(), Niels);
Course OOP = new(Courses.OOP.ToString(), Niels);

Enrollment enrollmentList = new()
{
    Enrollments = new List<Enrollment>() {}
};

List<Courses> coursesList = Enum.GetValues(typeof(Courses)).Cast<Courses>().ToList();

var addStudentCheck = true;
do
{
    var idCheck = true;
    var studentid = new int();
    do
    {
        try
        {
            Console.Write("Angiv elevens id: ");
            studentid = Convert.ToInt32(Console.ReadLine());
            idCheck = false;
        }
        catch (Exception)
        {
            Console.WriteLine("Der skete en fejl. Prøv igen!");
        }
    } while (idCheck);

    Console.Write("Angiv elevens fornavn: ");
    var firstname = Console.ReadLine();
    Console.Write("Angiv elevens efternavn: ");
    var lastname = Console.ReadLine();

    var dateCheck = true;
    var dateofbirth = new DateTime();
    do
    {
        try
        {
            Console.Write("Angiv elevens fødselsdag (Format: (dag)/(måned)/(år) ex. 20/9/1994): ");
            var dateInString = Console.ReadLine();
            if (string.IsNullOrEmpty(dateInString))
            {
                throw new Exception();
            }
            dateofbirth = new(Convert.ToInt32(dateInString.Split("/")[2]),
                Convert.ToInt32(dateInString.Split("/")[1]), Convert.ToInt32(dateInString.Split("/")[0]));
            dateCheck = false;
        }
        catch (Exception)
        {
            Console.WriteLine("Der skete en fejl. Prøv igen!");
        }
    } while (dateCheck);

    Student student = new(studentid, firstname, lastname, dateofbirth);
    var courseCheck = true;
    do
    {
        Console.WriteLine($"Angiv fag (vælg fra følgende fag):\n{string.Join("\n", coursesList)}\n");
        var fag = Console.ReadLine();
        if (string.IsNullOrEmpty(fag))
        {
            Console.WriteLine("Du skrev ikke noget");
        }
        else if (fag.ToLower() == Courses.Studieteknik.ToString().ToLower())
        {
            enrollmentList.Enrollments.Add(new Enrollment(student, Studieteknik));
            courseCheck = false;
        }
        else if (fag.ToLower() == Courses.Grundprog.ToString().ToLower())
        {
            enrollmentList.Enrollments.Add(new Enrollment(student, Grundprog));
            courseCheck = false;
        }
        else if (fag.ToLower() == Courses.OOP.ToString().ToLower())
        {
            enrollmentList.Enrollments.Add(new Enrollment(student, OOP));
            courseCheck = false;
        }
        else
        {
            Console.WriteLine("Du skrev ikke et rigtig fag");
        }
    } while (courseCheck);

    foreach (var enrollment in enrollmentList.Enrollments)
    {
        Console.WriteLine($"{enrollment.StudentInfo.FirstName} {enrollment.StudentInfo.LastName}, fag: {enrollment.CourseInfo.CourseName}, " +
                          $"lærer: {enrollment.CourseInfo.TeacherInfo.FirstName} {enrollment.CourseInfo.TeacherInfo.LastName}");
    }

    Console.Write("Vil du tilføje flere elever? Skriv ja eller nej : ");
    var continueCheck = Console.ReadLine();
    var answerCheck = true;
    do
    {
        try
        {
            if (string.IsNullOrEmpty(continueCheck))
            {
                throw new Exception();
            }

            if (continueCheck.ToLower() == "ja")
            {
                Console.Clear();
                Console.WriteLine("Fortsætter");
                answerCheck = false;
            }
            else if (continueCheck.ToLower() == "nej")
            {
                Console.WriteLine("Stopper...");
                answerCheck = false;
                addStudentCheck = false;
            }
            else
            {
                Console.WriteLine("Der skete en fejl. Prøv igen");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Der skete en fejl. Prøv igen!");
        }
    } while (answerCheck);
} while (addStudentCheck);
//Console.WriteLine("alexander's courses:");
//foreach (var course in Alexander.GetAllCourses(enrollmentList))
//{
//    Console.WriteLine(course);
//}

//foreach (var course in Alexander.GetAllCourses(test))
//{
//    Console.WriteLine(course);
//}

//enrollmentList.Enrollments.Sort();

//try
//{
//    Grundprog.CourseStudentAmount(enrollmentList);
//}
//catch (Exception exp)
//{
//    Console.WriteLine(exp.Message);
//}


//foreach (var enrollment in enrollmentList.Enrollments)
//{
//    Console.WriteLine($"{enrollment.StudentInfo.FirstName} {enrollment.StudentInfo.LastName}, fag: {enrollment.CourseInfo.CourseName}, " +
//                      $"lærer: {enrollment.CourseInfo.TeacherInfo.FirstName} {enrollment.CourseInfo.TeacherInfo.LastName}");
//}

