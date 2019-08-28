using GoldenShoe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoldenShoe.Controllers
{
    public class HomeController : Controller
    {

        List<ProductModel> shoeList = new List<ProductModel>();

        public HomeController()
        {

            shoeList.Add(new ProductModel { productID = 1, productName = "Shoe Pink Large", productDescription = " escription various data", amountInStore = 50, starRating = 5, sizeAvailable = new Dictionary<string, int> { { "7", 15 }, { "8,5", 5 }, { "6", 35 } } });
            shoeList.Add(new ProductModel { productID = 3, productName = "Blue shoe for dwarfs", productDescription = " description various data", amountInStore = 5, starRating = 1, sizeAvailable = new Dictionary<string, int> { { "4,5", 12 }, { "7", 5 }, { "9", 11 } } });
            shoeList.Add(new ProductModel { productID = 2, productName = "Shoe Blue Medium", productDescription = " description various data", amountInStore = 36, starRating = 4, sizeAvailable = new Dictionary<string, int> { { "6,5", 15 }, { "12", 18 }, { "8", 23 } } });
            shoeList.Add(new ProductModel { productID = 3, productName = "Shoe Red Small", productDescription = " description various data", amountInStore = 150, starRating = 3, sizeAvailable = new Dictionary<string, int> { { "5", 0 }, { "4", 2 }, { "9", 11 } } });
            shoeList.Add(new ProductModel { productID = 1, productName = "Brown Large shoe", productDescription = " escription various data", amountInStore = 50, starRating = 5, sizeAvailable = new Dictionary<string, int> { { "7", 15 }, { "8,5", 5 }, { "6", 35 } } });
            shoeList.Add(new ProductModel { productID = 3, productName = "Orange Shoe", productDescription = " description various data", amountInStore = 5, starRating = 1, sizeAvailable = new Dictionary<string, int> { { "4,5", 12 }, { "7", 5 }, { "9", 11 } } });
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult MensShoes()
        {
            ViewBag.Title = "Mens shoes Page";

            return View();
        }

        public ActionResult ChildrenShoes()
        {
            ViewBag.Title = "Mens shoes Page";

            return View(shoeList);
        }

        public ActionResult WomensShoes()
        {
            ViewBag.Title = "Mens shoes Page";

            return View();
        }
    }
}
