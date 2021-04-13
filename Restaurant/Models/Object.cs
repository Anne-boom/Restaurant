using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Object
    {
        
        public int ObjectId { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
    }
}
