namespace AplicadaFinal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vehiculo")]
    public partial class vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehiculo()
        {
            orden = new HashSet<orden>();
        }

        [Key]
        public int id_vehiculo { get; set; }

        [Required]
        [StringLength(50)]
        public string patente { get; set; }

        public int id_modelo { get; set; }

        public int? id_cliente { get; set; }

        [StringLength(50)]
        public string annio { get; set; }

        public virtual cliente cliente { get; set; }

        public virtual modelo modelo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orden> orden { get; set; }
    }
}
