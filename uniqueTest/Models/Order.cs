using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace uniqueTest.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "שם המנה")]
        public string DishName { get; set; }
        [Display(Name = "מחיר")]
        public double Price { get; set; }
        [Display(Name ="חומרים אלרגניים")]
        public bool Allergic { get; set; }
        [Display(Name ="קטגוריה")]
        public string TypeDish { get; set; }
    }
}
