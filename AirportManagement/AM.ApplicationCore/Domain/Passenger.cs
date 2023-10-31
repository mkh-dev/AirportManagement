using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }

        [EmailAddress(ErrorMessage = "L'adresse e-mail n'est pas valide.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        [MaxLength(250, ErrorMessage = "La longueur maximale du prénom est de 250 caractères côté interface.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le nom de famille est obligatoire.")]
        [MaxLength(250, ErrorMessage = "La longueur maximale du nom de famille est de 250 caractères côté interface.")]
        public string LastName { get; set; }
        [Key]
        public string PassportNumber { get; set; }
        public string TelNumber { get; set; }
        public IList<Flight> Flights { get; set; }
        public virtual string PassengerType { get { return "Unknown passenger type"; } }
        public override string ToString()
        {
            return $"PassportNumber : {PassportNumber}, FirstName : {FirstName}, LastName : {LastName}";
        }
    }
}
