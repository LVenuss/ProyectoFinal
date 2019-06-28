namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            FacturaDetalle = new HashSet<FacturaDetalle>();
            ProductoPedido = new HashSet<ProductoPedido>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProducto { get; set; }

        public int idBodega { get; set; }

        [Required]
        [StringLength(20)]
        public string nombre { get; set; }

        [Required]
        [StringLength(15)]
        public string marca { get; set; }

        [Required]
        [StringLength(15)]
        public string modelo { get; set; }

        public int codigoBarra { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        public int existencia { get; set; }

        public double preciocompra { get; set; }

        public double porcIV { get; set; }

        public double porcIVA { get; set; }

        [Required]
        [StringLength(1)]
        public string estado { get; set; }

        public int precioventa { get; set; }

        [Required]
        [StringLength(1)]
        public string excento { get; set; }

        public virtual Bodega Bodega { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaDetalle> FacturaDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoPedido> ProductoPedido { get; set; }
    }
}
