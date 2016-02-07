using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GraniteWorld.Models
{
    public class Sale
    {
        [Key, ForeignKey("Inventory")]
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public int AssociateId { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime SaleDate { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual Customer Customer { get; set; }

    }
}