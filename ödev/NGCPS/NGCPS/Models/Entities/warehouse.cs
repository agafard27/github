using System.ComponentModel.DataAnnotations;

namespace NGCPS.Models.Entities
{
    public class warehouse
    {
        [Key]
        public int ware_id { get; set; }


        public string? ware_code { get; set; }


        public string? ware_desc { get; set; }


        public required bool ware_status { get; set; }
    }
}
