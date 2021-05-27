using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Products.Models;
public class ProductsController : Controller
{
    List<ProductModel> products = new List<ProductModel>
            {
                new ProductModel {Id = 1 , Name ="Retro Controller",Price=200,Image ="https://cdn130.picsart.com/237253844035212.png"},
                new ProductModel {Id = 2 , Name ="Radio",Price=100,Image = "https://lh3.googleusercontent.com/proxy/t74NuI2fkz2CnNkoW5sPa66NCsu5GLcSpTb9u2X_s4OgjfOU-GPuBMx6xECx3oRcoAqY6eBEyR4tx_h-hD9P5I57qz7TcdPg"},
                new ProductModel{Id = 3 , Name ="Retro TV",Price=150, Image ="https://lh3.googleusercontent.com/proxy/bOc2qWvw8eqc6NDCqP66zIXmf5nLBQrrwjimOOYO9GxR980GE1Is2ncg_zo5McmAT2kNyDcKdHff3pyzMNvQbzFFvYQ7Xra9"},
                new ProductModel {Id = 4 , Name ="Science Book",Price=40,Image = "https://lh3.googleusercontent.com/proxy/0bu5lTkscTqwNI0Z3uFw7o74YVSPVdgbVBRE6UphIEfosZmCACjxRWhX8k9jVMBBHxciy9o8bmSsOrS5Y-3vA6ddbquZ6o4Y"},
                 new ProductModel {Id = 5 , Name ="Floppy Disk",Price=20,Image = "http://s3.amazonaws.com/draw.heroku.com/4ef4508a87ea76ab97ac6e6519644b23d511070c.png"}
                 
            };
    public IActionResult Index()
    {
        ViewData["prodects"] = products;
        return View();
    }
    public IActionResult Details(int? id)
    {
        ProductModel product = products.Find(p => p.Id == id);
        if (product == null)
        {
            return Content("No book found");
        }
        else
        {
            ViewData["prodects"] = product;
            return View();
        }
    }
    public IActionResult Random()
    {
        return View();
    }
}