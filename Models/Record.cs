using System;
using System.ComponentModel.DataAnnotations;

namespace RandomWordRecord.Models
{
    public class Record
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}