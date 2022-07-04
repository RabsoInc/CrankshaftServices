using System.ComponentModel.DataAnnotations;

namespace CrankshaftServices.Models.Foundation
{
    public class Title
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Title Description")]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Interal Map Code")]
        [MaxLength(125)]
        public string Mapcode { get; set; }
    }
}