using System;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Dataaloqalar
{
    class Program
    {
        static void Main(string[] args)
        {

            using (Usercontext db = new Usercontext())
            {
               

                Country c1 = new Country() { Name = "AQSH" };
                Country c2 = new Country() { Name = "Canada" };

                db.Countries.AddRange(c1, c2);


                Company a = new Company() { Name = "Google", Country = c1 };
                Company a1 = new Company() { Name = "Microsoft", Country = c2 };
                db.Companies.AddRange(a, a1);


                User b = new User() { Name = "Shohruh", Company = a };
                User b1 = new User() { Name = "Shohzod", Company = a };
                User b2 = new User() { Name = "Eldor", Company = a1 };
                User b3 = new User() { Name = "Sherzod", Company = a1 };
                User b4 = new User() { Name = "Bekzod", Company = a1 };

                db.Users.AddRange(b, b1, b2, b3, b4);
                db.SaveChanges();
            }
                //var users = db.Users.ToList();

                //foreach (var i in users)
                //{
                    //Console.WriteLine($"ismi {i.Name}  kompaniyasi={i.Company.Name}");
                //}

                //Company company = db.Companies.FirstOrDefault();
                //if(company!=null)
                //{
                //    db.Companies.Remove(company);
                //    db.SaveChanges();
                //}

                using(Usercontext db =new Usercontext())
                {
                var use = db.Users.Include(i => i.Company)
                    .ThenInclude(i => i.Country).ToList();

                foreach(var i in use)
                {
                    Console.WriteLine($"ismi={i.Name} - Ishxonasi={i.Company?.Name}  - davlati={i.Company?.Country?.Name} ");
                }
                }

                //var companies = db.Companies.Include(i => i.Users).ToList();

                //foreach(var i in companies)
                //{
                //    Console.WriteLine($"Kompaniya nomi={i.Name}");
                //    foreach(var u in i.Users)
                //    {
                //        Console.WriteLine($"ismi ={u.Name}");
                //    }
                //}
                //var users1 = db.Users.ToList();

                //foreach (var i in users1)
                //{
                //    Console.WriteLine($"ismi {i.Name} company={i.Company?.Name} ");
                //}

            
               

            
        }
    }
}
