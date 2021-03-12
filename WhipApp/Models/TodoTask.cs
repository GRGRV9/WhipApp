using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhipApp.Models
{
    public class TodoTask
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [StringLength(30, MinimumLength = 3)]        
        [Required]
        public string Title { get; set; }
           
        [StringLength(80)]
        public string Description { get; set; }

        [Display(Name = "Due datetime")]
        [DataType(DataType.DateTime)]
        public DateTime DueDateTime { get; set; }
        
    }
}
