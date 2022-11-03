using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBase64.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public Foto? Foto { get; set; }
        public ICollection<Curriculo>? Curriculos { get; set; }
    }
}