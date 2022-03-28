using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Jackson_Brynne_HW4.Models
{
    public enum ProductType { hat, pants, sweatshirt, tank, Tshirt, other }
    public class Product
    {
        //Primary key
        public Int32 ProductID { get; set; }

        //Navigational properties
        [Required(ErrorMessage = "Product name is required!")]
        [Display(Name = "Product Name:")]
        public String Name { get; set; }

        [Display(Name = "Desciption:")]
        public String Description { get; set; }


        [Required(ErrorMessage = "Price is required!")]
        [Display(Name = "Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Price { get; set; }

        //TODO: Doesn't need to be navigational property unsure if it needs to be here
        [Display(Name = "Product Type:")]
        public ProductType Type { get; set; }
    }
}
