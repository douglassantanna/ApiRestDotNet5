﻿using System.ComponentModel.DataAnnotations;
using FilmesAPI.Models;

namespace FilmesAPI.Data.DTOs
{
    public class ConsultarCinemaDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        
        public Gerente Gerente { get; set; }

    }
}
