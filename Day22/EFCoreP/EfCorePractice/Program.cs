﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EfCorePractice
{
    public class Product
    {
        [Key]
        public int Id{get; set;}
        public string Name{get; set;}
    }
    public class ProductContext : DbContext
    {
        private const string cs = "Host=localhost;Port=5432;User ID=postgres;Password=12345678;Database=PracticeDB;Pooling=true";
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseNpgsql(cs);
        }
        public DbSet<Product> products{get; set;}  //table name will be in database product
    }
    public class ProductOperation
    {
        ProductContext productContext = new ProductContext();
        public void FetchProduct(int id)
        {
            /* var temp = productContext.products.Find(1);
            if (temp != null)
	        {
		        Console.WriteLine(temp.Name);
	        } */

            /* var temp = (from s in productContext.products where s.Id==id select s).FirstOrDefault<Product>();
            Console.WriteLine(temp.Name); */

            var temp3 = productContext.products.Where(e=>e.Id==id).FirstOrDefault();
            Console.WriteLine(temp3.Name);
        }
        /* public void InsertProduct(Product products)
        {
            productContext.Add(products);
            productContext.SaveChanges();
            Console.WriteLine(products.Id + " " + products.Name);
        } */

        /* public void DeleteProduct(int id)
        {
            var delObj = productContext.products.Where(e=>e.Id==id).FirstOrDefault();
            productContext.Remove(delObj);
            productContext.SaveChanges();
            Console.WriteLine("Deleted");
        } */

        public void UpdateProduct(Product products1)
        {
            var upObj = productContext.products.Where(e=>e.Id==products1.Id).FirstOrDefault();
            upObj.Name = products1.Name;
            productContext.SaveChanges();
            Console.WriteLine("Updated Successfulley");
        }

    }



    class Program
    {
        public static void Main()
        {
           ProductOperation productOperation = new ProductOperation();
           productOperation.FetchProduct(1); 

           Product prod = new Product();
           prod.Id=4;
           prod.Name="Salman";
           //productOperation.InsertProduct(prod);

           //productOperation.DeleteProduct(3);

           productOperation.UpdateProduct(prod);



        }
    }
}
