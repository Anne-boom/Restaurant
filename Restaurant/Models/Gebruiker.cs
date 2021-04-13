using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Gebruiker
    {

        public int GebruikerId { get; set; }
        public string Naam { get; set; }
        public string Password { get; set; }

        public int Kamer { get; set; }

        public List<Object> Rugzak { get; set; }
    }
}
