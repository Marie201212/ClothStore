using ClothStore.Domain.Concrete;
using ClothStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothStore.App.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product


        public EFProductRepo Product { get; set; }
       
        public ActionResult List()
        {
            //Products = new EFDbContext();
            return View(Product.Products);
        }
    }
}