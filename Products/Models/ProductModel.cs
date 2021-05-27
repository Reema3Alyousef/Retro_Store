using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Products.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
    }
}
