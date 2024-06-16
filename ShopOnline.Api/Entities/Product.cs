﻿namespace ShopOnline.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal Qty { get; set;}
        public int CategoryId { get; set; }


    }
}
