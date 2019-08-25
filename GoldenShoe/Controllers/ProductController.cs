﻿using GoldenShoe.Models;
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
        List<Product> shoe = new List<Product>();

        public ProductController()
        {
           

            shoe.Add(new Product { productID = 1, productName= "Shoe Pink Large", productDescription=" escription various data", amountInStore = 50, starRating = 5 });
            shoe.Add(new Product { productID = 2, productName ="Shoe Blue Medium", productDescription = " description various data", amountInStore = 36, starRating = 4 });
            shoe.Add(new Product { productID = 3, productName ="Shoe Red Small", productDescription = " description various data", amountInStore = 150, starRating = 3 });
        }




        // GET: api/Product
        public List<Product> Get()
        {
            return shoe;
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return shoe.Where(x => x.productID == id).FirstOrDefault();
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}