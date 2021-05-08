using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace birgabir
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                Company company1 = new Company() { Name = "Microsoft"  };
                Company company2 = new Company() { Name = "Google" };
                Company company3 = new Company() { Name = "Alibaba" };
                Company company4 = new Company() { Name = "FaceBook"};
                Company company5 = new Company() { Name = "Chrome" };
                Company company6 = new Company() { Name = "Iphion"};

                db.Companies.AddRange(company1, company2, company3, company4, company5);


                User user1 = new User() { Name="Shohruh", Company=company4};
                User user2 = new User() { Name="Asqar", Company = company2 };
                User user3 = new User() { Name = "Malika", Company = company6 };
                User user4 = new User() { Name = "Nodir", Company = company4 };
                User user5 = new User() { Name = "Botir", Company = company5 };
                User user6 = new User() { Name = "Shahboz", Company = company3 };
                User user7 = new User() { Name = "Izzat", Company = company5 };
                User user8 = new User() { Name = "Nurbek", Company = company3 };


                db.Users.AddRange(user1, user2, user3, user4, user5, user6, user7, user8);

             
               
                db.SaveChanges();
                var users = db.Users.Include(i => i.Company).ToList();

                foreach (var i in users)
                {
                    Console.WriteLine($"ismi={i.Name}  kompaniyasi={i.Company.Name}");
                }
                var comp = db.Companies.Include(i => i.Users).ToList();
                Console.WriteLine("kompaniya buyicha\n");

                foreach(var i in comp)
                {
                    Console.WriteLine($"kompaniya={i.Name}");

                    foreach(var u in i.Users)
                    {
                        Console.WriteLine($"ismi={u.Name}");
                    }
                }

                var users1 = db.Users.FirstOrDefault(u => u.Name == "Shohruh");
                if (users1 != null)
                {
                    users1.Name = "Shoha";
                    db.SaveChanges();
                }

                var comp1 = db.Companies.FirstOrDefault(u => u.Name == "Google");
                if (comp1 != null)
                {
                    comp1.Name = "Google amaki";
                    db.SaveChanges();
                }

                var user11 = db.Users.Include(i => i.Company).ToList();
                Console.WriteLine("uzgartirilgandan keyin");
                foreach (var i in user11)
                {
                    Console.WriteLine($"ismi={i.Name}  kompaniyasi={i.Company.Name}");
                }
                var comp11 = db.Companies.Include(i => i.Users).ToList();
                Console.WriteLine("kompaniya buyicha\n");

                foreach (var i in comp11)
                {
                    Console.WriteLine($"kompaniya={i.Name}");

                    foreach (var u in i.Users)
                    {
                        Console.WriteLine($"ismi={u.Name}");
                    }
                }
            }
            using (UserContext db = new UserContext())
            {
                

            }
        }
    }
}
