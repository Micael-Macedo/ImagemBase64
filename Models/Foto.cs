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
        public string? FotoUsuario { get; set; }
        [ForeignKey("Usuario")]
        public int? FkUsuario { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}