using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Assignment1DHall.Models
{
    public class Lake
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = "unspecified";
        [Required]
        [MaxLength(50)]
        public string Location { get; set; } = "unspecified";
        [Comment("in Kilometres squared")]
        public int Volume { get; set; }
    }
}
