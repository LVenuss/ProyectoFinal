namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaginaUsuario")]
    public partial class PaginaUsuario
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPagina { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUsuario { get; set; }

        [Required]
        [StringLength(1)]
        public string ver { get; set; }

        [Required]
        [StringLength(1)]
        public string modificar { get; set; }

        [Required]
        [StringLength(1)]
        public string insertar { get; set; }

        [Required]
        [StringLength(1)]
        public string eliminar { get; set; }

        public virtual Pagina Pagina { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
