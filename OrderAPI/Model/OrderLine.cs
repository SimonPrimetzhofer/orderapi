using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Model
{
    public class OrderLine
    {
        [Key]
        public int Id { set; get; }

        [Required]
        public int Amount { set; get; }

        [Required]
        public string Description { set; get; }
    }
}
