using System.ComponentModel.DataAnnotations;

namespace NGCPS.Models.AddDto
{
    public class AddWarehouseDto
    {
        [Key]
        public int ware_id { get; set; }

        public string? ware_code { get; set; }


        public string? ware_desc { get; set; }


        public required bool ware_status { get; set; }
    }
}
