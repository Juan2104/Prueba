
namespace SistemaSLS.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TipoPersona")]
    public partial class TipoPersona
    {
        [Key]
        [StringLength(6)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }
    }
}
