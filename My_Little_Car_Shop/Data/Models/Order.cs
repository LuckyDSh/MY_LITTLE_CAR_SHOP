/*
 *  TickLuck Team
 *  All rights reserved 
 */

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace My_Little_Car_Shop.Data.Models
{
    public class Order
    {
        public int id { get; set; }
        [Display(Name = "Enter Name")]
        [StringLength(10)]
        [Required(ErrorMessage = "Name length should be less then 10 symbols")]
        public string name { get; set; }

        [Display(Name = "Enter Surname")]
        [StringLength(10)]
        [Required(ErrorMessage = "Surname length should be less then 10 symbols")]
        public string surname { get; set; }

        [Display(Name = "Address")]
        [StringLength(30)]
        [Required(ErrorMessage = "Address length should be less then 30 symbols")]
        public string address { get; set; }

        [Display(Name = "Phone")]
        [DataType (DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "name length should be less then 20 symbols")]
        public string phone { get; set; }

        [Display(Name = "Enter Name")]
        [DataType(DataType.EmailAddress)]
        [StringLength(10)]
        [Required(ErrorMessage = "name length should be less then 10 symbols")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
