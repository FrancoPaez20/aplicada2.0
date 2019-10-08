namespace AplicadaFinal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ordenempleado")]
    public partial class ordenempleado
    {
        [Key]
        public int id_ordenemple { get; set; }

        public int? id_empleado { get; set; }

        public int? id_orden { get; set; }

        public virtual empleado empleado { get; set; }

        public virtual orden orden { get; set; }
    }
}
