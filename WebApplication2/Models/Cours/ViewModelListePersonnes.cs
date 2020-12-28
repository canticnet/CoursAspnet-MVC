namespace Cours.Models
{
  public class ViewModelListePersonnes
  {
    public Personne2[] Personnes { get; set; }
    public int SelectedId { get; set; }

    public ViewModelListePersonnes()
    {
      Personnes = new Personne2[] { 
        new Personne2 { IdPersonne = 0, Prénom = "Pierre", Nom = "Martino" }, 
        new Personne2 { IdPersonne = 1, Prénom = "Pauline", Nom = "Pereiro" }, 
        new Personne2 { IdPersonne = 2, Prénom = "Jacques", Nom = "Alfonso" } };
      SelectedId = 2;
    }
  }

  public class Personne2
  {
    public int IdPersonne { get; set; }
    public string Nom { get; set; }
    public string Prénom { get; set; }
  }
}