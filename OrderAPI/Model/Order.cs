using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Model
{
    public class Order
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public DateTime DateTo { set; get; }
        [Required]
        public Customer customer { set; get; }
        [Required]
        public ICollection<OrderLine> OrderLines { set; get; }
        //Default Done = false
        public bool Done { set; get; }
    }
}
