using System;
using System.ComponentModel.DataAnnotations;

namespace AirportLastJourney.Models
{
    public class User
    {
        [Key]
        public int id_user { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public bool isAdmin { get; set; }

    }
}
