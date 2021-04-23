using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    public class Movie
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Title cannot be null")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Title should have between 3 or 60 characteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Release date cannot be null")]
        [DataType(DataType.DateTime, ErrorMessage = "Date is not valid")]
        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w]*$", ErrorMessage = "Type is not valid")]
        [StringLength(30, ErrorMessage = "30 characteres max")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Price cannot be null")]
        [Range(1, 1000, ErrorMessage = "Price should between 1 and 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Ratings cannot be null")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Numbers only")]
        public int Ratings { get; set; }
    }
}
