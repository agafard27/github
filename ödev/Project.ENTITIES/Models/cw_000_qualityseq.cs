using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public  class cw_000_qualityseq
    {
        [Key]
       
        public int id { get; set; }
        public int? lastref{ get; set; }
    }
}
