using ClothStore.Domain.Abstract;
using ClothStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothStore.Domain.Concrete
{
    public class EFProductRepo : IProductsRepository
    {
        public EFDbContext _context { get; set; }
        public IEnumerable<Product> Products
        {
            get {
                //_context = new EFDbContext();
                return _context.Product;
            }
        }
    }
}
