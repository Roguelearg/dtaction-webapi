using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacosDotIoJourneyAgency2.Models
{
    public class Voyage
    {
        public int Id { get; set; }
        public DateTime DateD { get; set; }
        public DateTime DateF { get; set; }
        public virtual List<Ville> Etapes { get; set; }
    }
}