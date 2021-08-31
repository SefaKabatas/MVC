using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class People
    {
        [Required(ErrorMessage ="Enter name")] 
        public string Name { get; set; }
        [Required(ErrorMessage ="Enter e-mail")] 
        [EmailAddress(ErrorMessage ="etc = asdas@demo")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Enter phone")] 
        public string Phone { get; set; }
        [Required(ErrorMessage ="Select Confirm")] 
        public bool? Confirm { get; set; } //true false oto null
    }
}