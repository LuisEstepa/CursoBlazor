using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime StorageUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        //Relacion con productos (ProductEntity)
        public string ProductId { get; set; }

        public ProductEntity Product { get; set; }

        //Relacion con bodegas (WerehouseEntity)
        public string WarehouseId { get; set; }

        public WarehouseEntity Warehouse { get; set; }

        //Relacion con movimientos (InputOutputEntity)
        public ICollection<InputOutputEntity> InputOutputs { get;}

    }
}
