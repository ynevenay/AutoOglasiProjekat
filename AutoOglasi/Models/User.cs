using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace AutoOglasi.Models
{
    public class User
    {
        [Required(ErrorMessage = "Korisnicko ime je obavezno")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email je obavezan")]
        [EmailAddress(ErrorMessage = "Pogresan email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lozinka je obavezna")]
        public string Password { get; set; }
    }
}
