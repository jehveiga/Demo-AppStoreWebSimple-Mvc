using AppLojaWebMvc.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppLojaWebMvc.Models
{
    public class Fornecedor : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")] // O {0} representa o nome do campo referido
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} a {1} caracteres", MinimumLength = 2)] // Ordem de parametros do StringLength {0}Campo, {1}Maximo e {2}Minimo
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")] // O {0} representa o nome do campo referido
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} a {1} caracteres", MinimumLength = 11)] // Ordem de parametros do StringLength {0}Campo, {1}Maximo e {2}Minimo
        public string Documento { get; set; }
        [Display(Name = "Tipo de Fornecedor")]
        public TipoFornecedor TipoFornecedor { get; set; }
        [Display(Name = "Endereço")]
        public Endereco Endereco { get; set; }

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relations */
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
