using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class InputOutputEntity
    {
        [Key]
        [StringLength(50)]
        public string InputOutputId { get; set; }

        [Required]
        public DateTime InputOutputDate { get; set; }

        [Required]
        public DateTime InputOutputUpdate { get; set; }

        [Required]
        public bool Quantity { get; set; }
    }
}
