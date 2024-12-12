using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExperienceSync.Models;
using Microsoft.AspNetCore.Identity;

namespace ExperienceSync.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ExperienceSyncUser class
public class ExperienceSyncUser : IdentityUser
{
    public ICollection<Local> Locales { get; set; } // Relación con Locales
    public ICollection<Tarea> Tareas { get; set; } // Relación con Tareas
}

