using Cours.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Linq;

namespace Cours.Controllers
{
  public class CoursController : Controller
  {
    // Index
    public ActionResult Index()
    {
      return View();
    }

        // Action09-GET
        //Affichage du formulaire avec HELPERS et transmission des valeurs
        [HttpGet]
        public ViewResult DecrireZoo20(ModeleApplicationZoo application)
        {
            ViewBag.info = string.Format("Contrôleur={0}, Action={1}", RouteData.Values["controller"], RouteData.Values["action"]);
            return View("FormulaireZoo_AvecHelpers", new ModeleVueZoo(application));
        }

        //Récupération des valeurs puis affichage du formulaire
        [HttpPost]
        public ViewResult RecevoirDescriptionZoo20(ModeleApplicationZoo application, FormCollection posted)
        {
            ViewBag.info = string.Format("Contrôleur={0}, Action={1}", RouteData.Values["controller"], RouteData.Values["action"]);
            ModeleVueZoo modèle = new ModeleVueZoo(application);
            TryUpdateModel(modèle, posted);
            // traitement des valeurs non postées
            if (posted["CheckBoxesFieldOrigine"] == null)
            {
                modèle.CheckBoxesFieldOrigine = new string[] { };
            }
            if (posted["DropDownListFieldTypeAnimal"] == null)
            {
                // modèle.SimpleChoiceListFieldType = "";
                modèle.DropDownListFieldTypeAnimal = "";
            }
            if (posted["MultipleChoiceListField"] == null)
            {
                modèle.MultipleChoiceListField = new string[] { };
            }
            // affichage formulaire
            return View("FormulaireZoo_AvecHelpers", modèle);
        }

        // Action08-GET
        //Affichage du formulaire classique et transmission des valeurs
        [HttpGet]
        public ViewResult DecrireZoo(ModeleApplicationZoo application)
        {
            ViewBag.info = string.Format("Contrôleur={0}, Action={1}", RouteData.Values["controller"], RouteData.Values["action"]);
            return View("FormulaireZoo", new ModeleVueZoo(application));
        }

        // Action08-POST

        //Récupération des valeurs puis affichage du formulaire
        [HttpPost]
        public ViewResult RecevoirDescriptionZoo(ModeleApplicationZoo application, FormCollection posted)
        {
            ViewBag.info = string.Format("Contrôleur={0}, Action={1}", RouteData.Values["controller"], RouteData.Values["action"]);
            ModeleVueZoo modèle = new ModeleVueZoo(application);
            TryUpdateModel(modèle, posted);
            // traitement des valeurs non postées
            if (posted["CheckBoxesFieldOrigine"] == null)
            {
                modèle.CheckBoxesFieldOrigine = new string[] { };
            }
            if (posted["DropDownListFieldTypeAnimal"] == null)
            {
                // modèle.SimpleChoiceListFieldType = "";
                modèle.DropDownListFieldTypeAnimal = "";
            }
            if (posted["MultipleChoiceListField"] == null)
            {
                modèle.MultipleChoiceListField = new string[] { };
            }
            // affichage formulaire
            return View("FormulaireZoo", modèle);
        }


        // Lister les personnes concernées
        public ViewResult ListerAnimauxZoo(ViewModelZoo zoo)
        {
            if (zoo == null)
            {
                zoo = new ViewModelZoo();
            }
            return View("ListerAnimauxZoo", zoo);
        }
        public ViewResult ChoisirAnimal(ViewModelZoo modèle)
        {
            Animal animalChoisi = modèle.zoo[modèle.SelectedId];
            return View("DecrireAnimal", animalChoisi);
        }
            public ViewResult DecrireAnimal(ViewModelZoo modèle)
        {
           Animal animalChoisi = modèle.zoo[modèle.SelectedId];
            animalChoisi.TypeAnimal = (string)modèle.ListeDeroulante_TypeAnimal.SelectedValue;
            animalChoisi.RepasAnimal = (string)modèle.ListeDeroulante_Repas.SelectedValue;

            /* modèle.ListeDeroulante_Repas
         ViewData["ListeDeroulante_TypeAnimal"] = modèle.ListeDeroulante_TypeAnimal;
           ViewData["ListeDeroulante_Repas"] = modèle.ListeDeroulante_Repas;
           ViewData["BoutonRadio_DangerAnimal"] = modèle.BoutonRadio_DangerAnimal;
           ViewData["CaseCocher_Originel"] = modèle.CaseCocher_Origine;
          */
            return View("DecrireAnimal", modèle);
        }


        // Lister les personnes concernées
        public ViewResult ListerPersonnes()
    {
      return View("ListerPersonnes", new ViewModelListePersonnes());
    }

    // Action06-POST
    [HttpPost]
    public ViewResult ChoisirPersonne(ViewModelListePersonnes modèle)
    {

            Personne2 personneChoisie = modèle.Personnes[modèle.SelectedId];
      return View("AfficherPersonneChoisie", personneChoisie);
    }
        
       
        // ---------------------------------- helpers
        // ensemble des messages d'erreur
        private string getErrorMessagesFor(ModelStateDictionary état)
    {
      List<String> erreurs = new List<String>();
      string messages = string.Empty;
      if (!état.IsValid)
      {
        foreach (ModelState modelState in état.Values)
        {
          foreach (ModelError error in modelState.Errors)
          {
            erreurs.Add(getErrorMessageFor(error));
          }
        }
        foreach (string message in erreurs)
        {
          messages += string.Format("[{0}]", message);
        }
      }
      return messages;
    }

    // le message d'erreur lié à un élément du modèle de l'action
    private string getErrorMessageFor(ModelError error)
    {
      if (error.ErrorMessage != null && error.ErrorMessage.Trim() != string.Empty)
      {
        return error.ErrorMessage;
      }
      if (error.Exception != null && error.Exception.InnerException == null && error.Exception.Message != string.Empty)
      {
        return error.Exception.Message;
      }
      if (error.Exception != null && error.Exception.InnerException != null && error.Exception.InnerException.Message != string.Empty)
      {
        return error.Exception.InnerException.Message;
      }
      return string.Empty;
    }
  }

}

