namespace NGCPS.Models.UpdateDto
{
    public class UpdateWarehouseDto
    {

        public string? ware_code { get; set; }


        public string? ware_desc { get; set; }


        public required bool ware_status { get; set; }
    }
}
