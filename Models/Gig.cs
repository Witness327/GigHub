﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public IdentityUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public String Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }


    }

}
