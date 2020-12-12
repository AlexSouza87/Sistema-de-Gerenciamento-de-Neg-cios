using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerenciadorDeNegocios.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string NumeroDaCasa { get; set; }
        public string Bairro { get; set; }
        public Cidade Cidade { get; set; }
        public string Cep { get; set; }
        public string PontoDeReferencia { get; set; }
        public ICollection<ClienteEndereco> ClienteEnderecos { get; set; }
    }
}
