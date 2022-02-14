using System;
using System.Linq;
using LinqPractices.DbOperations;

namespace LinqPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();

            // Find();
            System.Console.WriteLine("-----Find-----");
            var student = _context.Students.Where(student => student.StudentID == 1).FirstOrDefault();
            student = _context.Students.Find(1);
            Console.WriteLine(student.Name);

            // FirstOrDefault();
            Console.WriteLine();
            Console.WriteLine("-----FirstOrDefault-----");
            student = _context.Students.Where(student => student.Surname == "Arda").FirstOrDefault();
            Console.WriteLine(student.Name);

            student = _context.Students.FirstOrDefault(x => x.Surname == "Arda");
            Console.WriteLine(student.Surname);

            // SingleOrDefault();
            Console.WriteLine();
            System.Console.WriteLine("-----SingleOrDefault-----");
            student = _context.Students.SingleOrDefault(student => student.Name == "Deniz");
            Console.WriteLine(student.Surname);

            // ToList();
            Console.WriteLine();
            System.Console.WriteLine("-----ToList-----");
            var studentList = _context.Students.Where(student => student.ClassID == 2).ToList();
            Console.WriteLine(studentList.Count);

            // OrderBy
            Console.WriteLine();
            System.Console.WriteLine("-----OrderBy-----");
            students = _context.Students.OrderBy(x => x.StudentID).ToList();
            foreach (var st in students)
            {
                Console.WriteLine(st.StudentID + " - " + st.Name + " - " + st.Surname);
            }

            // OrderByDescending
            Console.WriteLine();
            System.Console.WriteLine("-----OrderByDescending-----");
            students = _context.Students.OrderByDescending(x => x.StudentID).ToList();
            foreach (var st in students)
            {
                Console.WriteLine(st.StudentID + " - " + st.Name + " - " + st.Surname);
            }

            //Anonymous Object Result
            Console.WriteLine();
            System.Console.WriteLine("-----Anonymous Object Result-----");
            var anonymousObject = _context.Students
                                            .Where(x => x.ClassID == 2)
                                                .Select(x => new
                                                {
                                                    Id = x.StudentID,
                                                    FullName = x.Name + " " + x.Surname
                                                });

            foreach (var item in anonymousObject)
            {
                Console.WriteLine(item.Id + " - " + item.FullName);
            }
        }
    }
}
