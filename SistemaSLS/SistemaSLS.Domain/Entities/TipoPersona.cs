
namespace SistemaSLS.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TipoPersona")]
    public partial class TipoPersona
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


     
        public int id { get; set; }

        
        
        [StringLength(50)]
        public string descripcion { get; set; }
    }
}
