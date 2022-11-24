using Enum = OOP_Exercise1.Codes.Enum;

Student Alexander = new Student(1, "Alexander", "K. H. Runge", new DateTime(2005, 5, 2));
Student Amanda = new Student(2, "Amanda", "Elisabeth Vang Gudmand", new DateTime(1999, 6, 2));
Student Dennis = new Student(3, "Dennis", "Daniel B. Paaske", new DateTime(1981, 1, 22));
Student Ozan = new Student(4, "Ozan", "Korkmaz", new DateTime(1990, 10, 24));
Student Camilla = new Student(5, "Camilla", "Kløjgaard", new DateTime(1999, 3, 10));
Student Rune = new Student(6, "Rune", "Hansen", new DateTime(1999, 3, 10));
Student Sanjit = new Student(7, "Sanjit", "Pouden", new DateTime(1999, 3, 10));
Student Rasmus = new Student(8, "Rasmus", "Wiell", new DateTime(1999, 3, 10));

Teacher Peter = new Teacher("Programmering", "Peter", "Lindenskov", new DateTime(1970, 1, 1));
Teacher Niels = new Teacher("Programmering", "Niels", "Olesen", new DateTime(1972, 9, 11));

Course Clientside = new Course(Courses.Clientside.ToString(), Peter);
Course Studieteknik = new Course(Courses.Studieteknik.ToString(), Niels);
Course Grundprog = new Course(Courses.Grundprog.ToString(), Niels);
Course OOP = new Course(Courses.OOP.ToString(), Niels);
Course Databaseprog = new Course(Courses.Databaseprog.ToString(), Niels);
Course Computertek = new Course(Courses.Computertek.ToString(), Niels);
Course Netværk = new Course(Courses.Netværk.ToString(), Niels);


Enrollment enrollmentList = new Enrollment();
enrollmentList.Enrollments = new List<Enrollment>()
{
    new Enrollment(Alexander, Clientside),
    new Enrollment(Alexander, Studieteknik),
    new Enrollment(Alexander, Grundprog),
    new Enrollment(Alexander, OOP),
    new Enrollment(Alexander, Databaseprog),
    new Enrollment(Alexander, Computertek),
    new Enrollment(Alexander, Netværk),
    new Enrollment(Amanda, Studieteknik),
    new Enrollment(Amanda, Grundprog),
    new Enrollment(Amanda, OOP),
    new Enrollment(Dennis, Studieteknik),
    new Enrollment(Dennis, Grundprog),
    new Enrollment(Dennis, OOP),
    new Enrollment(Ozan, Grundprog),
    new Enrollment(Ozan, OOP),
    new Enrollment(Camilla, Grundprog),
    new Enrollment(Camilla, OOP),
    new Enrollment(Rune, Grundprog),
    new Enrollment(Sanjit, Grundprog),
    new Enrollment(Rasmus, Grundprog),

};
Enrollment ListTest = new Enrollment();
ListTest.Enrollments = new List<Enrollment>()
{
    new Enrollment(Ozan, Grundprog),
    new Enrollment(Ozan, OOP),
    new Enrollment(Camilla, Grundprog),
    new Enrollment(Camilla, OOP),
};


//Console.WriteLine("alexander's courses:");
//foreach (var course in Alexander.GetAllCourses(enrollmentList))
//{
//    Console.WriteLine(course);
//}

List<Enrollment> test = new()
{
    ListTest,
    enrollmentList
};

//foreach (var course in Alexander.GetAllCourses(test))
//{
//    Console.WriteLine(course);
//}

enrollmentList.Enrollments.Sort();

try
{
    Grundprog.CourseStudentAmount(Grundprog.GetAllStudents(enrollmentList));
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}

foreach (var enrollment in enrollmentList.Enrollments)
{
    Console.WriteLine($"{enrollment.StudentInfo.FirstName} {enrollment.StudentInfo.LastName}, fag: {enrollment.CourseInfo.CourseName}, " +
                      $"lærer: {enrollment.CourseInfo.TeacherInfo.FirstName} {enrollment.CourseInfo.TeacherInfo.LastName}");
}

