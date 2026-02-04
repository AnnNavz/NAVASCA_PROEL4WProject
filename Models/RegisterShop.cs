using System.ComponentModel.DataAnnotations;

namespace NAVASCA_PROEL4WProject.Models
{
    public class RegisterShop
    {
        [Key]
        public int ShopID { get; set; }

        [Required(ErrorMessage = "Shop name is required")]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Shop Name")]
        public string ShopName { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Pickup Address")]
        public string PickupAddress { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
    }
}
