using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exemple_03.Models
{
    public class MaFamille
    {
        public List<Personne> Famille { get; set; }

        public MaFamille()
        {
            Famille = new List<Personne>();
            
        }
    }

    public class Personne
    {
        public int Age { get; set; }
        public  string Nom { get; set; }

        public string Sexe { get; set; }

        public Personne(int age, string nom, string sexe)
        {
            Age = age;
            Nom = nom;
            Sexe = sexe;
        }
    }

   

}