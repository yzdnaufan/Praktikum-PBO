namespace Chapter_5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kontak")]
    public partial class Kontak
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Required]
        [StringLength(200)]
        public string Alamat { get; set; }

        [Required]
        [StringLength(20)]
        public string No_Telp { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
