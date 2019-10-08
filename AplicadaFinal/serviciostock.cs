namespace AplicadaFinal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("serviciostock")]
    public partial class serviciostock
    {
        [Key]
        public int id_serviciostock { get; set; }

        public int id_servicio { get; set; }

        public int id_stock { get; set; }

        public virtual servicio servicio { get; set; }

        public virtual stock stock { get; set; }
    }
}
