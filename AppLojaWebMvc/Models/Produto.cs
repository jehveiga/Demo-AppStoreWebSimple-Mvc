using System;
using System.ComponentModel.DataAnnotations;

namespace AppLojaWebMvc.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* EF Relation */
        public Fornecedor Fornecedor { get; set; }

    }
}
