using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Genre
    {
        [Key]
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

    }
}
