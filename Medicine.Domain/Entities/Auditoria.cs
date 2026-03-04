using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Domain.Entities
{
    public abstract class Auditoria
    {
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }

        public bool Activo { get; set; } = true;
    }
}
