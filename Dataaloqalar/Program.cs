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
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Position p1 = new Position() { Name = "Manager" };
                Position p2 = new Position() { Name = "Developer" };

                db.Positions.AddRange(p1, p2);

                City c1 = new City() { Name = "Washington" };
                City c2 = new City() { Name = "Chicago" };

                db.Cities.AddRange(c1, c2);

                Country c3 = new Country() { Name = "AQSH", City=c1 };
                Country c4 = new Country() { Name = "Canada" , City=c2};

                db.Countries.AddRange(c3, c4);


                Company a = new Company() { Name = "Google", Country = c3 };
                Company a1 = new Company() { Name = "Microsoft", Country = c4 };
                db.Companies.AddRange(a, a1);


                User b = new User() { Name = "Shohruh", Company = a , Position=p1};
                User b1 = new User() { Name = "Shohzod", Company = a, Position = p1 };
                User b2 = new User() { Name = "Eldor", Company = a1, Position = p2 };
                User b3 = new User() { Name = "Sherzod", Company = a1, Position = p1 };
                User b4 = new User() { Name = "Bekzod", Company = a1, Position = p2 };

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
                                      .ThenInclude(u => u.Country)
                                              .ThenInclude(t => t.City)
                                   .Include(o => o.Position).ToList();
                    
                foreach(var i in use)
                {
                    Console.WriteLine($"ismi={i.Name} - Lavozimi={i.Position?.Name}");
                    Console.WriteLine($"kompaniyasi={i.Company.Name}  shahari={i.Company?.Country.Name}  shahari={i.Company?.Country?.City.Name}");
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
