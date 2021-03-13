using System;
using System.ComponentModel.DataAnnotations;

namespace WhipApp.Models
{
    public class TodoTask
    {
        public int Id { get; set; }

        [Display(Name = "NAME")]
        [StringLength(30, MinimumLength = 3)]        
        [Required]
        public string Title { get; set; }

        [Display(Name = "DESCRIPTION")]
        [StringLength(80)]
        public string Description { get; set; }

        [Display(Name = "DUE DATE&TIME")]
        [DataType(DataType.DateTime)]
        public DateTime DueDateTime { get; set; }

        [Display(Name = "STATUS")]
        public bool Done { get; set; }
        
    }
}
