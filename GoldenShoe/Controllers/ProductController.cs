using GoldenShoe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace GoldenShoe.Controllers
{
    public class ProductController : ApiController
    {
        List<ProductModel> shoe = new List<ProductModel>();

        public ProductController()
        {

            shoe.Add(new ProductModel { productID = 1, productName= "Shoe Pink Large", productDescription=" escription various data", amountInStore = 50, starRating = 5, sizeAvailable = new Dictionary<string, int> { {"7",15 }, {"8,5", 5 }, {"6", 35 } } });
            shoe.Add(new ProductModel { productID = 2, productName ="Shoe Blue Medium", productDescription = " description various data", amountInStore = 36, starRating = 4, sizeAvailable = new Dictionary<string, int> { { "6,5", 15 }, { "12", 18 }, { "8", 23 } } });
            shoe.Add(new ProductModel { productID = 3, productName ="Shoe Red Small", productDescription = " description various data", amountInStore = 150, starRating = 3, sizeAvailable = new Dictionary<string, int> { { "5", 0 }, { "4", 2 }, { "9", 11 } } });
        }




        // GET: api/Product
        [HttpGet]
        public List<ProductModel> Get()
        {
            return shoe;
        }




        // GET: api/Product/5
        public ProductModel Get(int id)
        {
            return shoe.Where(x => x.productID == id).FirstOrDefault();
        }

        // POST: api/Product
        public void Post(ProductModel addingShoe)                                                          
        {
            shoe.Add(addingShoe);

        }

        //public string getShoeName(int number)
        //{
        //    var shoeName = shoe.Where(i => i.productID == number);
            
        //    return shoeName.ToString();
        //}

        // PUT: api/Product/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/Product/5
        //public void Delete(int id)
        //{
        //}
    }
}
