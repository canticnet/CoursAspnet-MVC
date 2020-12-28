using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

//LABENERE
namespace Cours.Models
{
  public class ModeleVueZoo
  {
    // les champs de saisie
    public string RadioButtonFieldDanger { get; set; }
    public string[] CheckBoxesFieldOrigine { get; set; }
    public string TextFieldNom { get; set; }
    public string PasswordField { get; set; }
    public string TextAreaFieldCommentaires { get; set; }
    public string DropDownListFieldRepas { get; set; }
        // public string SimpleChoiceListFieldType { get; set; }
        public string DropDownListFieldTypeAnimal { get; set; }
        public string[] MultipleChoiceListField { get; set; }

    // les collections à afficher dans le formulaire
    public ModeleApplicationZoo.Item[] RadioButtonFieldItemsDangereux { get; set; }
    public ModeleApplicationZoo.Item[] CheckBoxesFieldItemsOrigine { get; set; }
    public ModeleApplicationZoo.Item[] DropDownListFieldItemsRepas { get; set; }
        //  public ModeleApplicationZoo.Item[] SimpleChoiceListFieldItemsType { get; set; }
        public ModeleApplicationZoo.Item[] DropDownListFieldItemsTypeAnimal { get; set; }
        public ModeleApplicationZoo.Item[] MultipleChoiceListFieldItems { get; set; }

    // constructeurs
    public ModeleVueZoo()
    {
    }

    public ModeleVueZoo(ModeleApplicationZoo application)
    {
            // initialisation collections
      RadioButtonFieldItemsDangereux = application.RadioButtonFieldItemsDangereux;
     CheckBoxesFieldItemsOrigine = application.CheckBoxesFieldItemsOrigine;
      DropDownListFieldItemsRepas = application.DropDownListFieldItemsRepas;
            //SimpleChoiceListFieldItemsType = application.DropDownListFieldItemsTypeAnimal
            DropDownListFieldItemsTypeAnimal = application.DropDownListFieldItemsTypeAnimal;
            MultipleChoiceListFieldItems = application.MultipleChoiceListFieldItems;
            
            // initialisation champs
            RadioButtonFieldDanger = "1";
            CheckBoxesFieldOrigine = new string[] { "1", "2" };
      TextFieldNom = "Surnom/Nom";
      PasswordField = "secret";
      TextAreaFieldCommentaires = "Quelques\ncommentaires sur l'animal";
      DropDownListFieldRepas = "2";
      DropDownListFieldTypeAnimal = "3";
      MultipleChoiceListField = new string[] { "1", "3" };
    }
  }
}