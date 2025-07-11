﻿using System.ComponentModel.DataAnnotations;

namespace Library_Management_System.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; } // "Admin" or "User"
    }
}
