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
                var product = new Product();
                for (var i = 0; i < 10; i++)
                { product = new Product()
                {
                    Name = $"Coat{i}",
                    Description = $"Women leather Coat{i}",
                    Price = 900m+i,
                    Size = "XS",
                    Category="Women"
                };
                   var product1 = new Product()
                    {
                        Name = $"Coat{i}",
                        Description = $"Men leather Coat{i}",
                        Price = 910m + i,
                        Size = "L",
                        Category = "Men"
                    };
                    dbtext.Product.Add(product);
                    dbtext.Product.Add(product1);
                }
                
                dbtext.SaveChanges();
                Console.WriteLine("done");
                Console.ReadLine();
            } 
        }
    }
}
