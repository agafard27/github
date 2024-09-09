using Project.ENTITIES.Models.qualityEntiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.quality
{
    public class quality:qualitysq
    {
        public int qlty_id { get; set; }          // Maps to [qlty_id]
        public string qlty_code { get; set; }     // Maps to [qlty_code]
        public string qlty_desc { get; set; }     // Maps to [qlty_desc]
        public string qlty_tradingname { get; set; }  // Maps to [qlty_tradingname]
        public int? qlty_reed { get; set; }       // Maps to [qlty_reed] (assuming nullable)
        public int? qlty_density { get; set; }    // Maps to [qlty_density] (assuming nullable)
        public float qlty_status { get; set; }   // Maps to [qlty_status]
    }

    
}
