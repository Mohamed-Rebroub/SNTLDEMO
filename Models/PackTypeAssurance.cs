using AssuranceSNTL.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace AssuranceSNTL.Models
{
    public class PackTypeAssurance : BaseEntity
    {

        [Key]
        public int ID { get; set; }

        [Required]
        public int PackAssuranceID { get; set; }

        public PackAssurance PackAssurance { get; set; }

        [Required]
        public int TypeAssuranceID { get; set; }

        public TypeAssurance TypeAssurance { get; set; }
    }
}
