﻿
using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AgencyContext : IdentityDbContext<ECommerceUser>
    {
        public AgencyContext(DbContextOptions opt) : base(opt)
        {
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<ProductRecord> ProductRecords { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryRecord> CategoryRecords { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Promo> Promos { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ECommerceUser> ECommerceUsers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageResource> LanguageResources { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var productRecord = new ProductRecord
            {

            };

            var product1 = new Product
            {

                Id = 1,
                InStock = 10,
                Price = 200,
                Discount = 1910,
                CategoryId = 1,
                PublishDate = DateTime.Now,
                ModifiedOn = DateTime.Now,
                CoverPhotoId = 1,
                IsFeatured = true,
                isSlider = true,
                Rating = 4.5M,
                //ProductRecords = new List<ProductRecord>()
            };

            var productRecord1 = new ProductRecord
            {
                Id = 1,
                Description = "Diqqət mərkəzində olmağı xoşlayırsınızsa yeni" +
                "SAMSUNG GALAXY Z FOLD 3 smartfonu sizin üçündür. ",
                Name = "Samsung Galaxy Z Fold 3 12/256GB Green (SM-F926B)",
                Summary = "New Samsung Galaxy!",
                LanguageID = 1,
                ProductId = 1,  
            };

            var productRecord2 = new ProductRecord
            {
                Id = 2,
                Description = "Если вы любите быть в центре внимания, новый смартфон SAMSUNG GALAXY Z FOLD 3 создан для вас. " +
                "Главное отличие устройства — складной экран. ",
                Name = "Samsung Galaxy Z Fold 3 12/256GB Green (SM-F926B)",
                Summary = "Новый телефон Samsung Galaxy! ",
                LanguageID = 2,
                ProductId = 1,
                
            };
            //product1.ProductRecords.Add(productRecord1);
            //product1.ProductRecords.Add(productRecord2);
         

            modelBuilder.Entity<Language>().HasData(
            new Language
            {
                Id = 1,
                Name = "Azerbaijan",
                IconCode = "az.png",
                IsEnabled = true,
                ShortCode = "az"
            },

            new Language
            {
                Id = 2,
                Name = "Russian",
                IconCode = "ru.png",
                IsEnabled = true,
                ShortCode = "ru"
            }

            );
            modelBuilder.Entity<Product>().HasData(product1);
            modelBuilder.Entity<ProductRecord>().HasData(productRecord1);
            modelBuilder.Entity<ProductRecord>().HasData(productRecord2);
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                ParentCategoryId = null,
                DisplaySeqNo = 1,
                SanitizedName = "Telefon",
            });

            modelBuilder.Entity<CategoryRecord>().HasData(
                new CategoryRecord
            {
                Id = 1,
                Name = "Telefon",
                Description = "Telefon Descrp",
                Summary = "Tel Sum",
                CategoryID = 1


            },
                 new CategoryRecord
                 {
                     Id =2,
                     Name = "Телефон",
                     Description = "Описание",
                     Summary = "Суммарно",
                     CategoryID = 1


                 }


            );

        }
    }
}
