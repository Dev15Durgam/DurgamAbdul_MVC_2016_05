using System.ComponentModel.DataAnnotations;

namespace Durgam_AbdulAmir_Uppgift_1.Models
{
    public class Product
    {
        [Required, Range(1,20)]
        public int ProductID { get; set; }
        [Required, MinLength(3),MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string ProductText { get; set; }
       // [Required,ProductName]
        public string ProductNumber { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int PruductsInStock { get; set; }
    }
}