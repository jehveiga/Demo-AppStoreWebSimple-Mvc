using AppLojaWebMvc.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppLojaWebMvc.Models
{
    public class Fornecedor : Entity 
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        [Display(Name = "Tipo de Fornecedor")]
        public TipoFornecedor TipoFornecedor { get; set; }
        [Display(Name = "Endereço")]
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
