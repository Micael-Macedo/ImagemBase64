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
        public string? Foto { get; set; }
        [ForeignKey("Usuario")]
        public int? FkUsuario { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}