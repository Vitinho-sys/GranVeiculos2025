using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GranVeiculos2025.Models
{
    [Table("Cor")]
    public class Cor
    {
        [Key]
        public int Id {get; set; }

        [Required]
        [StringLength(30)]
        public string Nome {get; set; }
    }
}