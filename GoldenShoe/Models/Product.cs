using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldenShoe.Models
{
    public class Product
    {
        public int productID { get; set; } = 0;

        public string productName { get; set; } = "";

        public string productDescription { get; set; } = "";

        public int amountInStore { get; set; } = 0;

        public int starRating { get; set; } = 0;

        public Dictionary<string,int> sizeAvailable{ get; set; }

    }
}