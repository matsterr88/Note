using System;
using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    public class Notice
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Context { get; set; }

        [Required]
        public DateTime WriteDate { get; set; }

        [Required]
        public int ViewCount { get; set; }
    }
}
