using System.ComponentModel.DataAnnotations;

namespace NGCPS.Models.AddDto
{
    public class AddCustomerDto
    {

        [Key]
        public int cust_id { get; set; }
        public string? cust_code { get; set; }

        public string? cust_desc { get; set; }

        public string? cust_adress { get; set; }

        public string? cust_country { get; set; }

        public string? cust_city { get; set; }

        public string? cust_phone { get; set; }

        public bool? cust_status { get; set; }
    }
}
