using System.Collections.Generic;
using System.Web.Mvc;

namespace Cours.Models
{
  public class ViewModelZoo
  {
    public Animal[] zoo { get; set; }
        public int SelectedId { get; set; }
        public SelectList ListeDeroulante_TypeAnimal { get; set; }
        //public string BoutonRadio_DangerAnimal { get; set; }
        public SelectList ListeDeroulante_Repas { get; set; }
        //public string CaseCocher_Origine { get; set; }
        public ViewModelZoo()
        {
            zoo = new Animal[] { 
            new Animal { IdAnimal = 0, NomAnimal = "Serpent", SurnomAnimal = "Snake" },
            new Animal { IdAnimal = 1, NomAnimal = "Tigre", SurnomAnimal = "Sherkan" },
            new Animal { IdAnimal = 2, NomAnimal = "Ours", SurnomAnimal = "Balou" } ,
            new Animal { IdAnimal = 3, NomAnimal = "Lion", SurnomAnimal = "Roi" },
            new Animal { IdAnimal = 4, NomAnimal = "Chien", SurnomAnimal = "Rox" },
            new Animal { IdAnimal = 5, NomAnimal = "Dauphin", SurnomAnimal = "Flipper" } };

            List<string> maListeAnimaux = new List<string>();
            maListeAnimaux.Add("Amphibiens");
            maListeAnimaux.Add("Crocodiliens");
            maListeAnimaux.Add("Mamifères");
            maListeAnimaux.Add("Oiseaux");
            maListeAnimaux.Add("Poissons");
            maListeAnimaux.Add("Serpents");
            maListeAnimaux.Add("Autres");
            ListeDeroulante_TypeAnimal = new SelectList(maListeAnimaux);

            List<string> maListeRepas = new List<string>();
            maListeRepas.Add("Carnivores");
            maListeRepas.Add("Omnivores");
            maListeRepas.Add("Végétariens");

            ListeDeroulante_Repas = new SelectList(maListeRepas);

        }
}

  public class Animal
  {
    public int IdAnimal { get; set; }
        public string NomAnimal { get; set; }
        public string TypeAnimal { get; set; }
        public string SurnomAnimal { get; set; }
        public string RepasAnimal { get; set; }

    }
}