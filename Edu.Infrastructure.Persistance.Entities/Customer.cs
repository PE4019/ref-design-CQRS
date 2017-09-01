using System.ComponentModel.DataAnnotations;

namespace Edu.Infrastructure.Persistance.Entities
{
    public partial class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(30)]
        public string StreetAddress { get; set; }

        // Each Customer has a (delivery) PostalAddress

        public virtual PostalAddress PostalAddress { get; set; }
    }
}
