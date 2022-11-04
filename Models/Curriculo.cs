using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBase64.Models
{
    public class Curriculo
    {
        public int CurriculoId { get; set; }
        public string? Nome { get; set; }

        public ICollection<Foto>? Fotos { get; set; }
        
    }
}