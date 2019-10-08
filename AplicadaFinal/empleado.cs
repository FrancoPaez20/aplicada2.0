namespace AplicadaFinal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empleado")]
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            ordenempleado = new HashSet<ordenempleado>();
        }

        [Key]
        public int id_empleado { get; set; }

        [Required]
        [StringLength(50)]
        public string nombreyapellido { get; set; }

        [Required]
        [StringLength(50)]
        public string dni { get; set; }

        [Required]
        [StringLength(50)]
        public string direccion { get; set; }

        [StringLength(50)]
        public string correo { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        public int? id_tipo { get; set; }

        [Required]
        [StringLength(50)]
        public string contraseña { get; set; }

        public int? disponibilidad { get; set; }

        public virtual tipo tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordenempleado> ordenempleado { get; set; }
    }
}
