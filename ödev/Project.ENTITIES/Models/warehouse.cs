using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class warehouse
    {
        [Key]
        public int ware_id { get; set; }


        public string? ware_code { get; set; }


        public string? ware_desc { get; set; }

        [Required]
        public bool ware_status { get; set; }
    }
}
