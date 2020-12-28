using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
// LABENERE 
namespace Exemple_03.Models
{
    public class ActionModel04
    {
        [Required(ErrorMessage = "Le paramètre email est requis")]
        [EmailAddress(ErrorMessage = "Le paramètre email n'a pas un format valide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le paramètre AppartenancePol est requis")]
        [MinLength(2,ErrorMessage="Le paramètre AppartenancePol doit contenir au moins deux caractères")]
        public string AppartenancePol { get; set; }

        [Required(ErrorMessage = "Le paramètre jour est requis")]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Le paramètre jour doit avoir 1 ou 2 chiffres")]
        public string Jour { get; set; }

        public string Erreurs { get; set; }

        /*[Required(ErrorMessage = "Le paramètre info1 est requis")]
        [MaxLength(4, ErrorMessage = "Le paramètre info1 ne peut avoir plus de 4 caractères")]
        public string Info1 { get; set; }

        [Required(ErrorMessage = "Le paramètre info2 est requis")]
        [MinLength(2, ErrorMessage = "Le paramètre info2 ne peut avoir moins de 2 caractères")]
        public string Info2 { get; set; }

        [Required(ErrorMessage = "Le paramètre info3 est requis")]
        [MinLength(4, ErrorMessage = "Le paramètre info3 doit avoir 4 caractères exactement")]
        [MaxLength(4, ErrorMessage = "Le paramètre info3 doit avoir 4 caractères exactement")]
        public string Info3 { get; set; }
        */
    }
}