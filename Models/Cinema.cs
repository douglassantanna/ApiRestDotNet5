using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace apiRestDotNet5.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }
        public int EnderecoID { get; set; }
        public virtual Gerente Gerente { get; set; }
        public int GerenteId { get; set; }
        [JsonIgnore]
        public virtual List<Sessao> Sessoes { get; set; }
    }
}