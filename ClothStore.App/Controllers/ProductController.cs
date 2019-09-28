using ClothStore.App.Models;
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
        private int pageSize = 5;

        public EFProductRepo Product { get; set; }

        public ActionResult List(int currentPage=1, int itemsperpage=5, string category=null, string orderMethod=null)
        {
            ProductListModel ProductModel = new ProductListModel()
            {

                ProductList = Product.Products
        .OrderBy(p => p.ProductId)
        .Skip((currentPage - 1) * pageSize)
        .Take(pageSize),
                Pageinfo = {
                    CurrentPage=currentPage,
                    ItemsPerPage=itemsperpage,
                    TotalItems=Product.Products.Count()
                },
                Category = category

            };


            return View(ProductModel);
        }
    }
}