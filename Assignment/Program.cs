using Assignment.Contexts;
using Assignment.Conventions;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ITIDbContext dbContext = new ITIDbContext();

            //dbContext.Students.Add();


            //var dbContext = new ITIDbContext();

            
            AddStudent(new Student { FName = "Ahmed", LName = "Ali", Address = "Cairo", Age = 25, Dep_Id = 1 });

            var student = GetStudentById(1);
            Console.WriteLine($"Student: {student.FName} {student.LName}");

            student.Address = "Alexandria";
            UpdateStudent(student);

            DeleteStudent(student.ID);
        }


        // CRUD on Student
        static void AddStudent(Student student)
        {
            using (var context = new ITIDbContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        static Student GetStudentById(int id)
        {
            using (var context = new ITIDbContext())
            {
                return context.Students.FirstOrDefault(s => s.ID == id);
            }
        }

        static void UpdateStudent(Student student)
        {
            using (var context = new ITIDbContext())
            {
                context.Students.Update(student);
                context.SaveChanges();
            }
        }

        static void DeleteStudent(int id)
        {
            using (var context = new ITIDbContext())
            {
                var student = context.Students.Find(id);
                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                }
            }
        }

    }
}



