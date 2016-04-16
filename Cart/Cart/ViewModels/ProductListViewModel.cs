using Cart.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cart.ViewModels
{
    public class ProductListViewModel
    {
        [DataType("ProductList")]
        public IEnumerable<Product> Products { get; set; }

        public string FirstName { get; set; }

        public Product FeaturedProduct { get; set; }
    }
}