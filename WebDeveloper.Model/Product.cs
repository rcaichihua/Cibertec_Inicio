using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Product
    {
        [Display(Name = "Product_Id", ResourceType = typeof(Resource))]
        public int ID { get; set; }
        [Display(Name = "Product_Name", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        [Display(Name = "Product_ProductNumber", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "This field is required")]
        public string ProductNumber { get; set; }
        [Display(Name = "Product_Color", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "This field is required")]
        public string Color { get; set; }
        [Display(Name = "Product_ListPrice", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "This field is required")]
        public decimal ListPrice { get; set; }
        [Display(Name = "Product_SellEndDate", ResourceType = typeof(Resource))]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? SellEndDate { get; set; }
        [Display(Name = "Product_Price", ResourceType = typeof(Resource))]
        public double Price { get; set; }
        [Display(Name = "Product_Description", ResourceType = typeof(Resource))]
        public string Description { get; set; }
    }
}
