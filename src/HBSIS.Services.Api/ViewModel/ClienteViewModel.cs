using System;
using System.ComponentModel.DataAnnotations;

namespace HBSIS.Services.Api.ViewModel
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Nome é requerido")]
        [MinLength(2, ErrorMessage = "O tamanho minimo do Nome é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo do Nome é {1}")]
        [Display(Name = "Nome do Cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF ou CNPJ")]
        [MinLength(11, ErrorMessage = "O tamanho minimo do Nome é {1}")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "CPF ou CNPJ")]
        public string CpfCnpj { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [MaxLength(25, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}