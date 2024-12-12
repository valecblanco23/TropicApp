namespace ExperienceSync.Models
{
    public class Evento
    {
            public int EventoId { get; set; }
            public int ClienteId { get; set; } // FK a Cliente
            public DateTime Fecha { get; set; }
            public int Asistencia { get; set; }
            public int LocalId { get; set; } // FK a Local
            public int ServicioId { get; set; } // FK a Servicio

            // Navegación
            public Cliente Cliente { get; set; }
            public Local Local { get; set; }
            public Servicio Servicio { get; set; }
    }
}
