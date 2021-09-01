using System;
using System.ComponentModel.DataAnnotations;

namespace Artsy.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int BirthYear { get; set; }
        public int? DeathYear { get; set; }
        public bool IsDead { get => DeathYear > 0; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}