using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        /*
         *      Routes
         *      
         *      /product  -- list all the products (calls Index view
         *      /product/product?cat=DRINKS  -- list all products in a category
         *      /product/product?prod=10 -- list details for product by ID
         *      /admin/addform -- preset the user with a form to add a product
         *      /admin/addprod -- create a new product
         *      /admin/editform?prodid=5 -- preset the user with a form to edit a product
         *      /admin/saveprod -- save edited product
         * */
        public IActionResult Index()
        {
            List<Products> results = DAL.GetAllProducts();
            return View(results);
        }

        public IActionResult product(int prod)
        {
            Products theprod = DAL.GetProduct(prod);
            return View(theprod);
        }

        public IActionResult delete(int id)
        {
            DAL.DeleteProducts(id);
            return Redirect("/product");
        }

        public IActionResult addform()
        {
            return View();
        }

        public IActionResult addprod(Products prod)
        {
            DAL.InsertProduct(prod);
            return Redirect("/product/");
        }

        public IActionResult editform(int prodid)
        {
            Products prod = DAL.GetProduct(prodid);
            return View(prod);
        }

        public IActionResult saveprod(Products prod)
        {
            DAL.UpdateProduct(prod);
            return Redirect($"/product/product?prod={prod.id}");
        }
    }
}
