using System;
using System.ComponentModel.DataAnnotations;

namespace AirportLastJourney.Models
{
    public class Flights
    {
        [Key]
        public int id_flight { get; set; }
        public Types type { get; set; }
        public DateTime eta { get; set; }
        public int countPas { get; set; }
        public double pricePas { get; set; }
        public int countCrew { get; set; }
        public double priceCrew { get; set; }
        public double procDop { get; set; }
        public double sum { get; set; }

    }
}
