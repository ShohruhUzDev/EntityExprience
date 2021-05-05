using System;
using System.Linq;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using(UserContext db=new UserContext())
            {
                User user1 = new User() { Name = "Shohruh", Age = 25 };
                User user2 = new User() { Name = "Shohzod", Age = 20 };

                db.Users.AddRange(user1, user2);
                db.SaveChanges();
                Console.WriteLine("dastur muvafaqiyatli ishladi");


                var users = db.Users.ToList();
                foreach(User i in users)
                {
                    Console.WriteLine($"ismi={i.Name}  yoshi={i.Age}");
                }
            }
            Console.ReadLine();
        }
    }
}
