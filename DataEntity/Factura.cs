namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            FacturaDetalle = new HashSet<FacturaDetalle>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idFactura { get; set; }

        public int idUsuario { get; set; }

        [Required]
        [StringLength(20)]
        public string formaPago { get; set; }

        public double totalDolares { get; set; }

        public double totalColones { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual FacturaCheque FacturaCheque { get; set; }

        public virtual FacturaContado FacturaContado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaDetalle> FacturaDetalle { get; set; }
    }
}
