namespace AplicadaFinal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ordenestado")]
    public partial class ordenestado
    {
        [Key]
        public int id_estado { get; set; }

        public int id_orden { get; set; }

        public int estado { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public virtual orden orden { get; set; }
    }
}
