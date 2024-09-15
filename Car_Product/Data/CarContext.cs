using Car_Product.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;

namespace Car_Product.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }



        #region Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id=1,
                Company= "پراید",
                Model="111",
                Color="آبی",
                Number_Plate= "پلاک:89 ط 255 ایران 11",
                Details= "بدون رنگ",
                Phone_Number= "09106778366",
                Photo= "perid11x1.jpg",
                Creation_Date= new DateTime(2024, 07, 11, 01, 06, 01),
               

            }, new Product()
            {
                Id = 2,
                Company = "پژو",
                Model = "405",
                Color = "قرمز",
                Number_Plate = "89س255 ایران 20",
                Details = "دور رنگ چپی ",
                Phone_Number = "09106778366",
                Photo = "1986987510.jpg",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 3,
                Company = "پژو",
                Model = "207",
                Color = "ابی",
                Number_Plate = "89ط 255 ایران 10",
                Details = "بدون رنگ مدل 1403",
                Phone_Number = "09106778366",
                Photo = "Peugeot-207-mc2.jpg",
                Creation_Date = DateTime.Now,

            }
            , new Product()
            {
                Id = 4,
                Company = "کیا",
                Model = "سورنتو",
                Color = "نقره ای",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "1627260479.jpg",
                Creation_Date = DateTime.Now,

            }
            , new Product()
            {
                Id = 5,
                Company = "کیا",
                Model = "سورنتو",
                Color = "نقره ای",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "1627260479.jpg",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 6,
                Company = "کیا",
                Model = "سورنتو",
                Color = "نقره ای",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "1627260479.jpg",
                Creation_Date = DateTime.Now,

            }
            , new Product()
            {
                Id = 7,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 8,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 9,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 10,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 11,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 12,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 13,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 14,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 15,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 16,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 17,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 18,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 19,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 20,
                Company = "کیا",
                Model = "سورنتو",
                Color = "قرمز",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ موتور سلامت",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }, new Product()
            {
                Id = 21,
                Company = "پژو",
                Model = "206",
                Color = "سفید",
                Number_Plate = "پلاک:89 ط 255 ایران 11",
                Details = "بدون رنگ مدل 1403",
                Phone_Number = "09106778366",
                Photo = "no",
                Creation_Date = DateTime.Now,

            }
            







            );






            base.OnModelCreating(modelBuilder);
        }
        #endregion











    }
}
