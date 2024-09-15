using Car_Product.Data;
using Car_Product.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Car_Product.Controllers
{
    public class AdminController : Controller
    {


        private CarContext _carDb;
        public AdminController( CarContext obj)
        {
        
            _carDb = obj;
        }


        public IActionResult Index()
        {
            var allCar = _carDb.Product;
            return View(allCar);
        }


        public IActionResult AddCar()
        {
            Mode_Product pro = new Mode_Product();

            return View(pro);
        }

        [HttpPost]
        public IActionResult AddCar(Mode_Product pro)
        {
            Random rand = new Random();
            int imgNameRandom=rand.Next();
            




            Product carForDb;
            pro.Creation_Date = DateTime.Now;
            if (!ModelState.IsValid)
            {
                return View(pro);
            }

            carForDb=new Product()
            {
                Company=pro.Company,
                Color=pro.Color,
                Model=pro.Model,
                Number_Plate=pro.Number_Plate,
                Phone_Number=pro.Phone_Number,
                Creation_Date=DateTime.Now,
                Details=pro.Details,
                
        };

            if (pro.Photo == null)
            {
                carForDb.Photo = "no";
            }
            else
            {
                carForDb.Photo = imgNameRandom + Path.GetExtension(pro.Photo.FileName);
            }

            if (pro.Photo?.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "img",
                    imgNameRandom + Path.GetExtension(pro.Photo.FileName));
                
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    pro.Photo.CopyTo(stream);
                }
            }






            _carDb.Add(carForDb);
            _carDb.SaveChanges();

     
            return Redirect("/");
        }


    }
}
