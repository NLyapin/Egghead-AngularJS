using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GraniteWorld.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal CostByWeight { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}