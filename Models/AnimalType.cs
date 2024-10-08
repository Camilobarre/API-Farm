using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Farm.Models
{
    [Table("animal_types")]
    public class AnimalType
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("name")]
        [MinLength(4, ErrorMessage ="The field Name must be at least 4 characters")]
        public required string Name { get; set; } // Por ejemplo mamífero
        
        [Column("description")]
        public string? Description { get; set; } // Por ejemplo son los tipos de animales que beben leche

    }
}