using System.ComponentModel.DataAnnotations;

namespace Aurora.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Informe o endereço")]
        public string? Endereco { get; set; }
        [Required(ErrorMessage = "Informe o número")]
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        [Required(ErrorMessage = "Informe o bairro")]
        public string? Bairro { get; set; }
        [Required(ErrorMessage = "Informe a cidade")]
        public string? Cidade { get; set; }
        [Required(ErrorMessage = "Informe o estado")]
        public string? Estado { get; set; }
        [Required(ErrorMessage = "Informe o CEP")]
        public string? Cep { get; set; }
        [Required(ErrorMessage = "Informe o telefone")]
        public string? Telefone { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
