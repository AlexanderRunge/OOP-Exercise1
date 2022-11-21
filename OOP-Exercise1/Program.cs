Student Alexander = new Student(1, "Alexander", "K. H. Runge", new DateTime(2005, 5, 2));
Student Amanda = new Student(2, "Amanda", "Elisabeth Vang Gudmand", new DateTime(1999, 6, 2));
Student Dennis = new Student(3, "Dennis", "Daniel B. Paaske", new DateTime(1981, 1, 22));
Student Ozan = new Student(4, "Ozan", "Korkmaz", new DateTime(1990, 10, 24));
Student Camilla = new Student(5, "Camilla", "Kløjgaard", new DateTime(1999, 3, 10));

Teacher Niels = new Teacher("Programmering", "Niels", "Olesen", new DateTime(1972, 9, 11));

Course Studieteknik = new Course("Studieteknik", Niels);
Course Grundprog = new Course("Grundprog", Niels);
Course OOP = new Course("OOP", Niels);

List<Enrollment> enrollments = new()
{
    new Enrollment(Alexander, Studieteknik),
    new Enrollment(Alexander, Grundprog),
    new Enrollment(Alexander, OOP),
    new Enrollment(Amanda, Studieteknik),
    new Enrollment(Amanda, Grundprog),
    new Enrollment(Amanda, OOP),
    new Enrollment(Dennis, Studieteknik),
    new Enrollment(Dennis, Grundprog),
    new Enrollment(Dennis, OOP),
    new Enrollment(Ozan, Grundprog),
    new Enrollment(Ozan, OOP),
    new Enrollment(Camilla, Grundprog),
    new Enrollment(Camilla, OOP)
};

foreach (var enrollment in enrollments)
{
    Console.WriteLine($"{enrollment.StudentInfo.FirstName} {enrollment.StudentInfo.LastName}, fag: {enrollment.CourseInfo.CourseName}, lærer: {enrollment.CourseInfo.TeacherInfo.FirstName} {enrollment.CourseInfo.TeacherInfo.LastName}");
}