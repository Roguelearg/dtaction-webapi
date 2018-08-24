using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacosDotIoJourneyAgency2.Models
{
    public class Ville
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual List<Voyage> Voyages { get; set; }
    }
}