using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Car_Product.Models
{
    public class Product
    {
        public int Id { get; set; }
      
        [Display(Name ="نوع")]
        public string Company { get; set; }
        [Display(Name = "مدل")]
        public string Model { get; set; }
        [Display(Name = "رنگ")]
        public string Color { get; set; }
        [Display(Name = "پلاک")]
        public string Number_Plate { get; set; }
        [Display(Name = "توضیحات")]
        public string Details { get; set; }
        [Display(Name = "شماره تماس")]
        public string Phone_Number { get; set; }
        public string Photo { get; set; }
        public DateTime Creation_Date { get; set; }


    }
}
