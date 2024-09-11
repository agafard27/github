using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication3.Models
{
    internal class Customer
    {
        [Key]
        public int cust_id { get; set; } 

        public string cust_code { get; set; }   

        public string cust_desc { get; set; }

        public string cust_adress { get; set; }

        public string cust_county { get; set; }

        public string cust_city { get; set; }

        public string cust_phone { get; set; }  

        public bool cust_status { get; set; }
    }
}
