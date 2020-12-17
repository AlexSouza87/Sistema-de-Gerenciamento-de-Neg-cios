using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerenciadorDeNegocios.Models
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string Nome { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual int EstadoId { get; set; }
    }
}
