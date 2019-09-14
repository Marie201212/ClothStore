using ClothStore.Domain.Abstract;
using ClothStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothStore.Domain.Concrete
{
    public class InMemoryProductRepo : IProductsRepository
    {

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        ProductId = 1,
                        Name = "Jacket",
                        Description = "Jacket for Moto",
                        Price = 100m,
                        Size = "xs"

                    },
                    {
                        new Product
                        {
                            ProductId = 1,
                            Name = "Robe",
                            Description = "Robe for Student",
                            Price = 120m,
                            Size = "xs"

                        }
                    }
                };

            }
        }
    }
}