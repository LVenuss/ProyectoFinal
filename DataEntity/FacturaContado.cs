namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturaContado")]
    public partial class FacturaContado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idFactura { get; set; }

        public double descuento { get; set; }

        public virtual Factura Factura { get; set; }
    }
}
