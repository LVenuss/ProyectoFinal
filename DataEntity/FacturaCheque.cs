namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturaCheque")]
    public partial class FacturaCheque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idFactura { get; set; }

        [Required]
        [StringLength(40)]
        public string nombreBanco { get; set; }

        public int numeroCheque { get; set; }

        public virtual Factura Factura { get; set; }
    }
}
