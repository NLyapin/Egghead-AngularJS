using GraniteWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraniteWorld.DAL
{
    //public class GraniteInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GraniteContext>
    public class GraniteInitializer : System.Data.Entity.DropCreateDatabaseAlways<GraniteContext>
    {
        protected override void Seed(GraniteContext context)
        {
            Random rand = new Random();
            var products = new List<Product>
            {
                new Product{ ProductName="Midnight Blue", ProductDescription="Beautiful blue and black patterns", CostByWeight=29.2M, ImagePath="/images/Granite1.jpg" },
                new Product{ ProductName="Red Speckled", ProductDescription="Chilean red, black, and grey pattern", CostByWeight=25.5M, ImagePath="/images/Granite1.jpg" },
                new Product{ ProductName="White Granite", ProductDescription="White with black veins", CostByWeight=22.5M, ImagePath="/images/Granite1.jpg" }
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var inventories = new List<Inventory>
            {
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Midnight Blue").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "Red Speckled").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
                new Inventory{ ProductId=products.First(p => p.ProductName == "White Granite").ProductId, Length=rand.Next(8,19), Width=rand.Next(5,9), Weight=rand.Next(301,411), ReceiveDate=DateTime.Now},
            };

            context.Inventories.AddRange(inventories);
            context.SaveChanges();

            var customers = new List<Customer>
            {
                new Customer() { Name="Robert Freeman", Address="123 Main St.", City="Cincinnati", State="OH", Zipcode="45233", HomePhone="555-555-3928", CellPhone="555-555-2233" },
                new Customer() { Name="Sally Bigg", Address="8273 Elm St.", City="Cincinnati", State="OH", Zipcode="45288", HomePhone="555-555-0394", CellPhone="555-555-9328" },
                new Customer() { Name="Tom Engelbrecht", Address="8839 Cherry Lane", City="Cincinnati", State="OH", Zipcode="45234", HomePhone="555-555-8372", CellPhone="555-555-7363" },
                new Customer() { Name="Ursula Morris", Address="837 Willow St.", City="Cincinnati", State="OH", Zipcode="45245", HomePhone="555-555-9830", CellPhone="555-555-8875" },
                new Customer() { Name="Victor Niles", Address="9303 Madison Ave.", City="Cincinnati", State="OH", Zipcode="45256-9854", HomePhone="555-555-8399", CellPhone="555-555-8844" },
                new Customer() { Name="Wally Graham", Address="383 Race Rd.", City="Cincinnati", State="OH", Zipcode="45233", HomePhone="555-555-8373", CellPhone="555-555-7463" },
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();

            var sales = new List<Sale>
            {
                new Sale() { CustomerId=customers[0].CustomerId, SaleId=inventories[0].InventoryId, SalePrice=inventories[0].Product.CostByWeight*inventories[0].Weight, SaleDate=DateTime.Now-(new TimeSpan(30,0,0,0)) },
                new Sale() { CustomerId=customers[0].CustomerId, SaleId=inventories[2].InventoryId, SalePrice=inventories[2].Product.CostByWeight*inventories[2].Weight, SaleDate=DateTime.Now-(new TimeSpan(32,0,0,0)) },
                new Sale() { CustomerId=customers[0].CustomerId, SaleId=inventories[5].InventoryId, SalePrice=inventories[5].Product.CostByWeight*inventories[5].Weight, SaleDate=DateTime.Now-(new TimeSpan(35,0,0,0)) },
                new Sale() { CustomerId=customers[1].CustomerId, SaleId=inventories[1].InventoryId, SalePrice=inventories[0].Product.CostByWeight*inventories[1].Weight, SaleDate=DateTime.Now-(new TimeSpan(3,0,0,0)) },
                new Sale() { CustomerId=customers[1].CustomerId, SaleId=inventories[3].InventoryId, SalePrice=inventories[2].Product.CostByWeight*inventories[3].Weight, SaleDate=DateTime.Now-(new TimeSpan(5,0,0,0)) },
                new Sale() { CustomerId=customers[2].CustomerId, SaleId=inventories[4].InventoryId, SalePrice=inventories[5].Product.CostByWeight*inventories[4].Weight, SaleDate=DateTime.Now-(new TimeSpan(7,0,0,0)) }
            };

            context.Sales.AddRange(sales);
            context.SaveChanges();
           
        }

    }
}