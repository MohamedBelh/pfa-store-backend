﻿using store.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace store.Dtos.Responce
{
    public class AttVarianteResponseDto
    {
        [Key]
        public int Id { get; set; }
        public String cle { get; set; }
        public String Valeur { get; set; }
        public Variante? Variante { get; set; }
        [ForeignKey("Variante")]
        public int VarianteId { get; set; }
    }
}
