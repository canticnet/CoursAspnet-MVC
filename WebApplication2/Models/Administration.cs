using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exemple_03.Models
{
   
        public class Employe
    {
        public List<ProjetInformatique> ListeProjetsDPT { get; set; }
        public int Age { get; set; }
        public string Nom { get; set; }

        public int IdEmploye { get; set; }

        public string Sexe { get; set; }
        public List<Certification> CV { get; set; }
        public Employe(int id, int age, string nom, string sexe)
        {
            IdEmploye = id;
            Age = age;
            Nom = nom;
            Sexe = sexe;
            CV = new List<Certification>();
            ListeProjetsDPT = new List<ProjetInformatique>();

        }

    }

    public class Certification
    {
        public int Annee { get; set; }
        public string Organisme { get; set; }
        public string Certificat { get; set; }

        public Certification(int an, string org, string cert)
        {
            Annee = an;
            Organisme = org;
            Certificat = cert;
        }
    }

    public class Departement
    {
        public List<ProjetInformatique> ListeProjetsDPT { get; set; }
        
        public List<Employe> Membres { get; set; }
        public string Nom { get; set; }

        public Departement(string nom)
        {
            Membres = new List<Employe>();
            ListeProjetsDPT = new List<ProjetInformatique>();
            Nom = nom;
        }
            public Departement(string nom , bool attribChefProjetProjet)
        {
            Membres = new List<Employe>();
            ListeProjetsDPT = new List<ProjetInformatique>();
            Nom = nom;

            Employe PhilippeJ = new Employe(0, 60, "Jardin", "M");
            Employe JeremyS = new Employe(1, 50, "Schlogel", "M");
            Employe BenoitJ = new Employe(2, 40, "Janin", "M");
            Employe MarcelC = new Employe(3, 50, "Cleodore", "M");

            Certification ITIL = new Certification(2019, "PeopleCert", "ITIL V4 Foundation");
            Certification PrinceF = new Certification(2020, "PeopleCert", "Prince Foundation");
            Certification PrincePractionner = new Certification(2020, "PeopleCert", "Prince Practionner");
            Certification Java = new Certification(2020, "Oracle", "Java8 Enterprise");
            Certification AspNet = new Certification(2018, "Microsoft", "Asp.net");
            Certification AspNetMVC = new Certification(2020, "Microsoft", "Asp.net MVC");
            Certification CISCOR = new Certification(2020, "CISCO", "Roouteurs");
            Certification CISCOC = new Certification(2020, "CISCO", "Commutateurs");

            PhilippeJ.CV.Add(PrinceF);
            BenoitJ.CV.Add(PrinceF);
            MarcelC.CV.Add(PrinceF);
            PhilippeJ.CV.Add(CISCOR);
            JeremyS.CV.Add(Java);
            JeremyS.CV.Add(AspNet);
            JeremyS.CV.Add(AspNetMVC);

            Membres.Add(PhilippeJ);
            Membres.Add(JeremyS);
            Membres.Add(BenoitJ);
            Membres.Add(MarcelC);

            int numProjet = 0;
            ProjetInformatique spationav = new ProjetInformatique(numProjet + 1, "Spationav");
            ProjetInformatique fropsbalard = new ProjetInformatique(numProjet + 2, "FrOpS Balard");
            ProjetInformatique siacd = new ProjetInformatique(numProjet + 3, "SIA CD");
            ProjetInformatique migrationDRM = new ProjetInformatique(numProjet + 4, "Migration DRM");
            ProjetInformatique siafropsmarine = new ProjetInformatique(numProjet + 5, "SIA FrOpS Marine");
            ProjetInformatique astel = new ProjetInformatique(numProjet + 6, "ASTEL");
            ProjetInformatique geode4d = new ProjetInformatique(numProjet + 7, "Geode4D");


            ListeProjetsDPT.Add(spationav);
            ListeProjetsDPT.Add(fropsbalard);
            ListeProjetsDPT.Add(siacd);
            ListeProjetsDPT.Add(migrationDRM);
            ListeProjetsDPT.Add(siafropsmarine);
            ListeProjetsDPT.Add(astel);
            ListeProjetsDPT.Add(geode4d);
        }


    }
    public class ProjetInformatique
    {
        public int idProjet { get; set; }
        public string Nom { get; set; }

        public ProjetInformatique(int num, string nom)
        {
            idProjet = num;
            Nom = nom;
        }


    }

}