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
    public class CustomersController : ApiController
    {
        private GraniteContext db = new GraniteContext();

        // GET: api/Customers
        public IHttpActionResult GetCustomers()
        {
            return Ok(db.Customers.Select(a => new 
            { 
                CustomerId = a.CustomerId, 
                Name = a.Name,
                Address = a.Address,
                City = a.City,
                State = a.State,
                Zipcode = a.Zipcode,
                HomePhone = a.HomePhone,
                CellPhone = a.CellPhone
            }).ToList()); 
        }

        // GET: api/Products
        [Route("api/customers/{id}/sales/{fromDate?}/{toDate?}")]
        public IHttpActionResult GetCustomerSales(int id, DateTime? fromDate=null, DateTime? toDate=null)
        {
            var list = db.Sales.Where(s => s.CustomerId == id).Select(a => new
            {
                SaleId = a.SaleId,
                AssociateId = a.AssociateId,
                CustomerId = a.CustomerId,
                CustomerName = a.Customer.Name,
                Width = a.Inventory.Width,
                Length = a.Inventory.Length,
                Weight = a.Inventory.Weight,
                ProductId = a.Inventory.ProductId,
                ProductName = a.Inventory.Product.ProductName,
                SaleDate = a.SaleDate,
                SalePrice = a.SalePrice
            }).ToList();

            if (fromDate != null && fromDate.HasValue) list = list.Where(c => c.SaleDate >= fromDate.Value).ToList();
            if (toDate != null && toDate.HasValue) list = list.Where(c => c.SaleDate <= toDate.Value).ToList();

            return Ok(list);
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