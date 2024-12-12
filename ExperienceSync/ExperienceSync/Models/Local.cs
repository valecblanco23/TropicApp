using ExperienceSync.Areas.Identity.Data;

namespace ExperienceSync.Models
{
    public class Local
    {
        public int LocalId { get; set; }
        public string AdministradorId { get; set; } // FK a Identity User
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Ubicacion { get; set; }

        // Navegación
        public ExperienceSyncUser Administrador { get; set; }
    }
}
