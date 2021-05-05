using System;
using System.Linq;

namespace Entity3
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StudenContext db = new StudenContext())
            {
                Student student1 = new Student() { Name = "shohruh", Age = 45 };
                Student student2 = new Student() { Name = "shohzod", Age = 25 };

                db.Students.AddRange(student1, student2);
                db.SaveChanges();

            }
            using(StudenContext db=new StudenContext())
            {
                var students = db.Students.ToList();
                foreach(var i in students)
                {
                    Console.WriteLine($"Ismi-{i.Name} yoshi={i.Age}");
                }
            }


            //using (StudenContext db=new StudenContext())
            //{

            //}

        }
    }
}
