using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaGerenciadorDeNegocios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerenciadorDeNegocios.View_Model
{
    public class ClienteViewModel
    {
        public Cliente Cliente { get; set; }
        public List<Estado> Estados { get; set; }
        public List<Cidade> Cidades { get; set; }
        public int IdEstado { get; set; }
        public int IdCidade { get; set; }
        public Endereco Endereco { get; set; }

    }
}
