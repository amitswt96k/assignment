using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuestApi.Models
{
    public enum Title
    {
        Mr,
        Mrs,
        Ms,
        Dr
    }

    public class Guest
    {
        [Key]
        public Guid Id { get; set; }

        public Title Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Lastname { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public List<string> PhoneNumbers { get; set; }
    }
}
