using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Models
{
    public class User
    {
        [Key]
        public int UID { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string PhoneNumber { get; set; }
    }
}
