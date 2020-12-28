using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
// LABENERE 
namespace Exemple_03.Models
{
    public class ActionModelChoixChefProjet
    {
        [Required(ErrorMessage = "Le paramètre Id du projet est requis")]
        public int IdProjet { get; set; }

        [Required(ErrorMessage = "Le paramètre Jardin de l'employé est requis")]
        public string Jardin { get; set; }
        public string Schlogel { get; set; }
        public string Janin { get; set; }
        public string Cleodore { get; set; }
    }
}