using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class cw_000_quality
    {
        [Key]
        public int? qty_referans { get; set; }
        public string? qty_kodu { get; set; }
        public string? qty_desc { get; set; }
        public string? qty_tickodu { get; set; }
        public string? qty_ticname { get; set; }
        
        public byte? qty_status { get; set; }
        
    }

}
