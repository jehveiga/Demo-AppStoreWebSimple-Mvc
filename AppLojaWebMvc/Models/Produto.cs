using System;
using System.ComponentModel.DataAnnotations;

namespace AppLojaWebMvc.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")] // O {0} representa o nome do campo referido
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} a {1} caracteres", MinimumLength = 2)] // Ordem de parametros do StringLength {0}Campo, {1}Maximo e {2}Minimo
        public string Nome { get; set; }

        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} a {1} caracteres", MinimumLength = 2)]
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descricao { get; set; }

        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} a {1} caracteres", MinimumLength = 2)] // Não precisa somente para não ocupar tanto espaço no banco
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Imagem { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")] // Definindo o formato que será apresentado no campo de dados na tela/campo
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)] // Definindo o tipo de dados que estará no campo
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")] // Definindo o formato da data que será exibido na tela/campo
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /* EF Relation */
        public Fornecedor Fornecedor { get; set; }

    }
}
