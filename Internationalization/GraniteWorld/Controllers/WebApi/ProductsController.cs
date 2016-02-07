using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GraniteWorld.DAL;
using GraniteWorld.Models;

namespace GraniteWorld.Controllers.WebApi
{
    public class ProductsController : ApiController
    {
        private GraniteContext db = new GraniteContext();

        // GET: api/Products
        public IHttpActionResult GetProducts()
        {
            var list = db.Products.Select(a => new
            {
                ProductId = a.ProductId,
                ProductName = a.ProductName,
                ProductDescription = a.ProductDescription,
                CostByWeight = a.CostByWeight,
                ImagePath = a.ImagePath,
                Inventories = a.Inventories.Where(i => i.Sale == null).Select(b => new
                {
                    InventoryId = b.InventoryId,
                    Length = b.Length,
                    Weight = b.Weight,
                    Width = b.Width,
                    IsAvailable = b.Sale == null
                })
            }).ToList();

            return Ok(list);
        }

        // POST: api/makesale
        [HttpPost]
        [Route("api/addinventory")]
        public IHttpActionResult PostSale(Inventory inventory)
        {
            if (inventory.Length < 4 || inventory.Width < 4 || inventory.Weight < 50) return this.InternalServerError(new Exception("Error in dimensions"));
            db.Inventories.Add(inventory);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw;
            }

            return Ok(inventory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}