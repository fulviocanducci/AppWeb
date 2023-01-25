using System.ComponentModel.DataAnnotations;

namespace WebValidations.Models
{
   public class People
   {
      [Required(ErrorMessage = "Digite o Id")]
      public int Id { get; set; }

      [Required(ErrorMessage = "Digite o nome")]
      public string Name { get; set; }
   }
}
