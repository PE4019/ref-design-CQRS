using System.ComponentModel.DataAnnotations;

namespace Edu.Infrastructure.Persistance.Entities
{
    public class PostalAddress
    {
        [Key]
        public int PostalAddressID { get; set; }

        [Required]
        [StringLength(10)]
        public string PostCode { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }
    }
}
