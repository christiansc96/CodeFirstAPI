using System;
using System.ComponentModel.DataAnnotations;

namespace Database.MyFirstAPI.DBModels
{
    public class Presentations
    {
        [Key]
        public int PresentationId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(200, ErrorMessage = "Only 200 characters accepted")]
        public string PresentationName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(500, ErrorMessage = "Only 500 characters accepted")]
        public string PresentationDescription { get; set; }

        public string Cover { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}