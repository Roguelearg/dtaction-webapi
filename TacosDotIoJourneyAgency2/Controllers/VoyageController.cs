using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using TacosDotIoJourneyAgency2.Models;

namespace TacosDotIoJourneyAgency2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VoyageController : ApiController
    {
        public IHttpActionResult Get()
        {
            JourneyAgencyDb db = new JourneyAgencyDb();
            return Ok(db.Voyage.ToList());
        }

        public IHttpActionResult Get(int id)
        {
            JourneyAgencyDb db = new JourneyAgencyDb();
            return Ok(db.Voyage.FirstOrDefault(v => v.Id == id));
        }

        public IHttpActionResult Post(Voyage voyage)
        {
            JourneyAgencyDb db = new JourneyAgencyDb();
            List<Ville> villes = new List<Ville>();
            foreach (var etape in voyage.Etapes)
            {
             villes.Add(db.Ville.FirstOrDefault(v => v.Id == etape.Id));
            }
            voyage.Etapes = villes;
            db.Voyage.Add(voyage);
            db.SaveChanges();
            return Ok();
        }
    }
}