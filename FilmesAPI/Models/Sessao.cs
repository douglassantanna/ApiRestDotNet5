using System;
using System.ComponentModel.DataAnnotations;

namespace apiRestDotNet5.Models
{
    public class Sessao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public virtual Cinema Cinema { get; set; }
        public virtual Filme Filme { get; set; }
        public int CinemaID { get; set; }
        public int FilmeID { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }
            
    }
}