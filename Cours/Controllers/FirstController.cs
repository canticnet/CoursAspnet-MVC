using Exemple_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// HERVE LABENERE CANTIC.NET
namespace Exemple_03.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Action01()
        {
            ViewBag.info = string.Format("Controleur={0}, Action={1}", RouteData.Values["Controller"], RouteData.Values["Action"]);
            return View();
        }

        public ViewResult Action02(ActionModel03 modele)
        {
            
            string erreurs = getErrorMessagesFor(ModelState);
            return View(
                new ViewModel01() 
                { Email = modele.Email, Jour = modele.Jour, Erreurs = erreurs });
        }


        public ViewResult Action04(ActionModel04 modele)
        {

            string erreurs = getErrorMessagesFor(ModelState);
            modele.Erreurs = erreurs;
            return View (modele);
                
        }

        public ViewResult AfficherFamille()
        {

            string erreurs = getErrorMessagesFor(ModelState);
            Personne Alban = new Personne(12, "Alban", "H");
            Personne Faustine = new Personne(10, "Faustine", "F");
            Personne Guilain = new Personne(08, "Guilain", "H");
            MaFamille ModeleVueFamille = new MaFamille();
            ModeleVueFamille.Famille.Add(Alban);
            ModeleVueFamille.Famille.Add(Faustine);
            ModeleVueFamille.Famille.Add(Guilain);
            return View(ModeleVueFamille);
        }

        public ViewResult AfficherDptASIM()
        {
            
            string erreurs = getErrorMessagesFor(ModelState);
            Departement monModeleVueDpt = new Departement("ASIM", false);

            return View(monModeleVueDpt);

        }
        public ActionResult AttribuerProjets()
        {
            /* ViewBag.IdProjet = fc["IdProjet"];
             ViewBag.NomChefProjet = fc["ChefProjet"];
            */
            string erreurs = getErrorMessagesFor(ModelState);
            Departement monModeleVueDpt = new Departement("ASIM", false);

            return View(monModeleVueDpt);
        }


        [HttpPost]
        //Ca fonctionne !!
        //Collection de formulaires paires clé/valeur
        public ActionResult ChoisirChefProjet(FormCollection fc)
        {
            Departement monModeleVueDptNonComplet = new Departement("ASIM", false);
            Departement monModeleVueDptComplet = new Departement("ASIM");
            foreach (ProjetInformatique p in monModeleVueDptNonComplet.ListeProjetsDPT)
            {
                foreach (var idProjetForm in fc.AllKeys)
                {
                    int monIdProjetForm = Int32.Parse(idProjetForm);
                    var IdEmploye = fc[idProjetForm];
                    int monIdChefProjet = Int32.Parse(IdEmploye);
                    if (monIdProjetForm == p.idProjet)
                    {
                        Employe chefProj = monModeleVueDptNonComplet.Membres[monIdChefProjet];
                        chefProj.ListeProjetsDPT.Add(p);
                        monModeleVueDptComplet.Membres.Add(chefProj);
                    }
                    
                    

                }

            }
            
            return View("VisualiserProjetsAttribues", monModeleVueDptComplet);
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
