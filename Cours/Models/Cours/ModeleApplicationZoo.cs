
namespace Cours.Models
{
    //LABENERE
  public class ModeleApplicationZoo
  {
    // les collections à afficher dans le formulaire
    public Item[] RadioButtonFieldItemsDangereux { get; set; }
    public Item[] CheckBoxesFieldItemsOrigine { get; set; }
    public Item[] DropDownListFieldItemsRepas { get; set; }
    public Item[] DropDownListFieldItemsTypeAnimal { get; set; }
    // public Item[] SimpleChoiceListFieldItemsType { get; set; }
    public Item[] MultipleChoiceListFieldItems { get; set; }

    // initialisation des champs et collections
    public ModeleApplicationZoo()
    {
        RadioButtonFieldItemsDangereux = new Item[]{
        new Item {Value="1",Label="oui"},
        new Item {Value="2", Label="non"}
      };
        CheckBoxesFieldItemsOrigine = new Item[]{
        new Item {Value="1",Label="Afrique"},
        new Item {Value="2", Label="Asie"},
        new Item {Value="3", Label="Amérique"},
        new Item {Value="4", Label="Océanie"}
      };
      DropDownListFieldItemsRepas = new Item[]{
        new Item {Value="1",Label="Herbivore"},
        new Item {Value="2", Label="Carnivore"},
        new Item {Value="3", Label="Omnivore"}
      };

        DropDownListFieldItemsTypeAnimal = new Item[]{
        new Item {Value="1",Label="Crocodiliens"},
        new Item {Value="2", Label="Mamifères"},
        new Item {Value="3", Label="Oiseaux"},
        new Item {Value="4", Label="Poissons"},
        new Item {Value="5", Label="Serpents / lézards"},
        new Item {Value="6", Label="Tortues"},
        new Item {Value="7",Label="Amphibiens"}
      };
           // SimpleChoiceListFieldItemsType = new Item[]{
        
         
     
      MultipleChoiceListFieldItems = new Item[]{
        new Item {Value="1",Label="liste1"},
        new Item {Value="2", Label="liste2"},
        new Item {Value="3", Label="liste3"},
        new Item {Value="4", Label="liste4"},
        new Item {Value="5", Label="liste5"}
      };
    }
    // l'élément des collections
    public class Item
    {
      public string Label { get; set; }
      public string Value { get; set; }
    }

  }
}