using ExperienceSync.Areas.Identity.Data;

namespace ExperienceSync.Models
{
    public class Tarea
    {
            public int TareaId { get; set; }
            public string UsuarioId { get; set; } // FK a Identity User
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
            public string Estado { get; set; } // Por ejemplo: "Pendiente", "Completa"

            // Navegación
            public ExperienceSyncUser Usuario { get; set; }

    }
}
