using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerenciadorDeNegocios.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }

    }
}
