namespace AplicadaFinal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stock")]
    public partial class stock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stock()
        {
            serviciostock = new HashSet<serviciostock>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_stock { get; set; }

        [Required]
        [StringLength(50)]
        public string detalle { get; set; }

        [Required]
        [StringLength(50)]
        public string precio { get; set; }

        [Required]
        [StringLength(50)]
        public string minimo { get; set; }

        [StringLength(50)]
        public string cantidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<serviciostock> serviciostock { get; set; }
    }
}
