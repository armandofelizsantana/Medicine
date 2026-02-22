using Medicine.Domain.Base;

namespace Medicine.Domain.Entities;

public class Medico : AuditEntity
{
    public string Nombre { get; set; }
    public string Especialidad { get; set; }
}
