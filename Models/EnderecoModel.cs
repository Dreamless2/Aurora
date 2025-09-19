using System.ComponentModel.DataAnnotations;

namespace Aurora.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string? Endereco { get; set; }
        [Required(ErrorMessage = "O campo Número é obrigatório")]
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string? Bairro { get; set; }
        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        public string? Cidade { get; set; }
        [Required(ErrorMessage = "O campo Estado é obrigatório")]
        public string? Estado { get; set; }
        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        public string? Cep { get; set; }
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        public string? Telefone { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
