using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProjectAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int ManufacturerID { get; set; }
        public long Price { get; set; }
        public string? Specifications { get; set; }
        [JsonIgnore]
        public virtual Manufacturer? Manufacturers { get; set; }
    }
}
