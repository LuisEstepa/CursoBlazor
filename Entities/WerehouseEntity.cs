using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WerehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WerehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WerehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WerehouseAddress { get; set; }
    }
}
