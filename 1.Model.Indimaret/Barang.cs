using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Indimaret
{
    [Table("mst_barang")]
    public class Barang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int TokoID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string KodeBarang { get; set; }

        [Column(TypeName="VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string NamaBarang { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string AsalPabrik { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int JmlBarang { get; set; }



        [Required(AllowEmptyStrings = false)]
        public int LamaKadaluarsa { get; set; }


    }
}
