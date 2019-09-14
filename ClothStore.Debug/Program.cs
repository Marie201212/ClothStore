using ClothStore.Domain.Concrete;
using ClothStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothStore.Debug
{
   public class Program
    {
        
        static void Main(string[] args)
        {
            using (var dbtext = new EFDbContext())
            {
                var product = new Product()
                {
                    Name = "Coat",
                    Description = "Women leather Coat",
                    Price = 900m,
                    Size = "XS"
                };
                dbtext.Product.Add(product);
                dbtext.SaveChanges();
                Console.WriteLine("done");
                Console.ReadLine();
            } 
        }
    }
}
