using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBase64.Models
{
    public class Foto
    {
        public int FotoId { get; set; }
        public string? FotoPerfil { get; set; }
        [ForeignKey("Curriculo")]
        public int? FkCurriculo { get; set; }
        public virtual Curriculo? Curriculo { get; set; }
    }
}