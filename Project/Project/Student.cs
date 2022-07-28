using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string University { get; set; }
        public int CurrentYear { get; set; }

        public static List<Student> PopulateStudents()
        {
            return new List<Student>
            {
                new Student { Id = 73, Name = "Tarah Symons", University = "UTCN", CurrentYear = 2 },
                new Student { Id = 12, Name = "Gracie Jacobs", University = "UBB", CurrentYear = 2 },
                new Student { Id = 34, Name = "Danny Barr", University = "UBB", CurrentYear = 3 },
                new Student { Id = 56, Name = "Tylor Kirk", University = "UTCN", CurrentYear = 3 },
                new Student { Id = 89, Name = "Ruby Moore", University = "UPB", CurrentYear = 1 },
                new Student { Id = 92, Name = "Tracie Bryan", University = "UTCN", CurrentYear = 3 },
                new Student { Id = 18, Name = "Kelvin Newport", University = "UTCN", CurrentYear = 1 }
            };
        }

        public override string? ToString() => $"{Id} | {Name} | {University} | {CurrentYear}";
    }
}
