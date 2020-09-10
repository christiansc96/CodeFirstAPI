using System;
using System.ComponentModel.DataAnnotations;

namespace Database.MyFirstAPI.DBModels
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(500, ErrorMessage = "Only 500 characters accepted")]
        public string CategoryDescription { get; set; }

        public string Cover { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}