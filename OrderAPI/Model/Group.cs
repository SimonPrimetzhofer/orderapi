using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Model
{
    public class Group
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string Description { set; get; }
    }
}
