using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        [Display(Name = "Product Number")]
        [Required(ErrorMessage = "This field is required")]
        public string ProductNumber { get; set; }
        [Display(Name = "Color")]
        [Required(ErrorMessage = "This field is required")]
        public string Color { get; set; }
        [Display(Name = "List Price")]
        [Required(ErrorMessage = "This field is required")]
        public decimal ListPrice { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? SellEndDate { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
