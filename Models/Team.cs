using System;
using System.ComponentModel.DataAnnotations;

namespace SSDLab1.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TeamName { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime? EstablishedDate { get; set; }

    }
}
