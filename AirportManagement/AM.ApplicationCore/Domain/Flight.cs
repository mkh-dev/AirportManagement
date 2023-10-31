using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        [Required(ErrorMessage = "Le champ Départ est obligatoire.")]
        public string Departure { get; set; }

        [Required(ErrorMessage = "Le champ Destination est obligatoire.")]
        public string Destination { get; set; }

        public DateTime EffectiveArrival { get; set; }
        public float EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        
        [ForeignKey("PlaneId")]
        public Plane Plane { get; set; }

        public IList<Passenger> Passengers { get; set; }
        public override string ToString()
        {
            return $"FlightId : {FlightId}, Destination : {Destination}, FlightDate : {FlightDate}";
        }
    }
}
