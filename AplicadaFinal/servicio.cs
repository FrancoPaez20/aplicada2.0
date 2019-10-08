namespace AplicadaFinal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("servicio")]
    public partial class servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public servicio()
        {
            ordenservicio = new HashSet<ordenservicio>();
            serviciostock = new HashSet<serviciostock>();
        }

        [Key]
        public int id_servicios { get; set; }

        [Required]
        [StringLength(50)]
        public string detalle { get; set; }

        [Required]
        [StringLength(50)]
        public string precio { get; set; }

        public int id_modelo { get; set; }

        public virtual modelo modelo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordenservicio> ordenservicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<serviciostock> serviciostock { get; set; }
    }
}
