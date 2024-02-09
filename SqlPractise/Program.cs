using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Ramstein",
                    Year = 1994
                };

                context.Groups.Add(group);
                context.SaveChanges();

                Console.WriteLine($"id: {group.Id}, name: {group.Name}, year: {group.Year}");
                Console.ReadLine();
            }
        }
    }
}
