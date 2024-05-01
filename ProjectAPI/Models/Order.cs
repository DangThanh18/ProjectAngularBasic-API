using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProjectAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}
