namespace DatabPBO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pasien")]
    public partial class Pasien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Required]
        [StringLength(20)]
        public string NIK { get; set; }

        [Required]
        [StringLength(200)]
        public string JenisKelamin { get; set; }

        [StringLength(80)]
        public string JenisTes { get; set; }
    }
}
