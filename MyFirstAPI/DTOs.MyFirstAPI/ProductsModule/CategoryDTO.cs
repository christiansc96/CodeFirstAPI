using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DTOs.MyFirstAPI.ProductsModule
{
    public class CategoryDTO : IValidatableObject
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(200, ErrorMessage = "Only 200 characters accepted")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(500, ErrorMessage = "Only 500 characters accepted")]
        public string CategoryDescription { get; set; }

        public string Cover { get; set; }

        public DateTime CreatedAt { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrWhiteSpace(this.CategoryName))
            {
                yield return new
                    ValidationResult(
                    "This field is required",
                    new[]
                    {
                        "CategoryName"
                    });
            }
        }
    }
}