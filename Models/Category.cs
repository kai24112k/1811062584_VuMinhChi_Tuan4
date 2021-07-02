using System.ComponentModel.DataAnnotations;

namespace _1811062584_VuMinhChi_Tuan3.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}