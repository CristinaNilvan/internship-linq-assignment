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