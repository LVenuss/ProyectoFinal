namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Telefono")]
    public partial class Telefono
    {
        [Key]
        [Column("telefono")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int telefono1 { get; set; }

        public int idProveedor { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
