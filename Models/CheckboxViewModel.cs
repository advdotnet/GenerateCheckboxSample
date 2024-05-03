using System.ComponentModel.DataAnnotations;

namespace GenerateCheckboxSample.Models
{
    public class CheckboxViewModel
    {
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
