using Medicine.Domain.Base;

namespace Medicine.Domain.Entities;

public class Usuario : AuditEntity
{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Rol { get; set; }
}