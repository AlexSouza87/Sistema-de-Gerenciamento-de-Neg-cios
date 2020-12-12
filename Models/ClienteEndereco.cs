using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerenciadorDeNegocios.Models
{
    public class ClienteEndereco
    {
        public int EnderecoId { get; set; }
        public int ClienteId { get; set; }
        public Endereco Endereco { get; set; }
        public Cliente Cliente { get; set; }

    }
}
