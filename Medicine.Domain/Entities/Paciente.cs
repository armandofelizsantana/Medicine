using Medicine.Domain.Base;

namespace Medicine.Domain.Entities;

public class Paciente : AuditEntity
{
    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }
}