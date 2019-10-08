namespace AplicadaFinal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ordenservicio")]
    public partial class ordenservicio
    {
        [Key]
        public int id_ordenservicio { get; set; }

        public int id_orden { get; set; }

        public int id_servicio { get; set; }

        public virtual orden orden { get; set; }

        public virtual servicio servicio { get; set; }
    }
}
