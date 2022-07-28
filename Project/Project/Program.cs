using Project;

var students = Student.PopulateStudents();

var numberOfStudents = students.Where(s => s.University.Equals("UTCN")).ToList().Count;
Console.WriteLine($"The number of students from UTCN is {numberOfStudents}.");
Console.WriteLine();

var groups = students.GroupBy(s => s.CurrentYear);
Console.WriteLine("Students grouped by current year:");
foreach (var group in groups)
{
    Console.WriteLine(group.Key);

    foreach (var student in group)
    {
        Console.WriteLine(student);
    }
}
Console.WriteLine();

var sortedStudents = students.OrderBy(s => s.CurrentYear).ThenBy(s => s.Name);
Console.WriteLine("Students sorted by current year and then by name:");
foreach (var student in sortedStudents)
{
    Console.WriteLine(student);
}
Console.WriteLine();

var bestStudent = students.OrderByDescending(s => s.GradeAverage).First();
Console.WriteLine($"The best student in the database is {bestStudent.Name} with {bestStudent.GradeAverage}.");
Console.WriteLine();

var namesOfStudents = students.OrderBy(s => s.Name).Select(s => s.Name);
Console.WriteLine("The names of the students in alphabetical order are:");
foreach (var student in namesOfStudents)
{
    Console.WriteLine(student);
}
Console.WriteLine();

var averageOfGrades = students.Average(s => s.GradeAverage);
Console.WriteLine($"The average of grades is {averageOfGrades}.");
Console.WriteLine();

var checkStudents = students.Any(s => s.GradeAverage < 5);
Console.WriteLine($"There are students with a grade average less than 5: {checkStudents}.");