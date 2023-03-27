using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        public string Result { get; set; }
      
        [Display(Name = "Twoje imie: ")]
        [Required(ErrorMessage = "Pole jest obowiązkowe"), MaxLength(100)]
        public string Name { get; set; }
        [Display(Name = "Twój rok urodzenia: ")]
        [Required(ErrorMessage = "Pole jest obowiązkowe"), Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        public int YearOfBirth { get; set; }
    }
}
