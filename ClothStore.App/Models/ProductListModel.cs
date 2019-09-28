using ClothStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothStore.App.Models
{
    public class ProductListModel
    {

        public IEnumerable<Product> ProductList { get; set; }
        public PageInfo Pageinfo { get; set; }
        public String Category { get; set; }


        //public SequenceInfo SequenceInfo { get; set; }

    }
}