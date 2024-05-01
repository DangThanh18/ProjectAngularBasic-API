using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerID { get; set; }
        public string ManufacturerName { get; set; }

    }
}
