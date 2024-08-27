using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudWithRazorPages.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required]
        [DisplayName("Price")]
        public double Price { get; set; }

        [Required]
        [DisplayName("Amount")]
        public int Amount { get; set; }


    }
}
