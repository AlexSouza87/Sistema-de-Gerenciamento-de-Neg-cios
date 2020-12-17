using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerenciadorDeNegocios.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        [DisplayName("Nº")]
        public string NumeroDaCasa { get; set; }
        public string Bairro { get; set; }
        public Cidade Cidade { get; set; }
        public string Cep { get; set; }
        [DisplayName("Ponto de referência")]
        public string PontoDeReferencia { get; set; }
        public ICollection<ClienteEndereco> ClienteEnderecos { get; set; }
    }
}
