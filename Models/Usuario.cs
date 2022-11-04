using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBase64.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string? Nome { get; set; }
        public Foto? Foto { get; set; }
        [ForeignKey("Curriculo")]
        public int? FkCurrilo { get; set; }
        public Curriculo? Curriculo { get; set; }
    }
}