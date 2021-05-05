using System;
using System.Linq;

namespace Entity2
{
    class Program
    {
        static void Main(string[] args)
        {
           using(userdbContext _db=new userdbContext())
            {
                var users = _db.Users.ToList();
                foreach(User i in users)
                {
                    Console.WriteLine($"Ismi={i.Name}  yoshi={i.Age}");
                }
            }
            Console.ReadKey();
        }
    }
}
