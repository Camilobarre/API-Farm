using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Farm.Models
{
    public class AnimalType
    {
        public int Id { get; set; }
        public required string Name { get; set; } // Por ejemplo mamífero
        public string? Description { get; set; } // Por ejemplo son los tipos de animales que beben leche

    }
}