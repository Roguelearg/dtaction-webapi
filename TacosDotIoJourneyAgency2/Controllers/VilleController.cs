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
    public class VilleController : ApiController
    {
        public IHttpActionResult Get()
        {
            JourneyAgencyDb db = new JourneyAgencyDb();
            return Ok(db.Ville.ToList());
        }

        public IHttpActionResult Get(int id)
        {
            JourneyAgencyDb db = new JourneyAgencyDb();
            return Ok(db.Ville.FirstOrDefault(v => v.Id == id));
        }

        public IHttpActionResult Post(Ville ville)
        {
            JourneyAgencyDb db = new JourneyAgencyDb();
            ville.Pays = db.Pays.FirstOrDefault(p => p.Id == ville.Pays.Id);
            db.Ville.Add(ville);
            db.SaveChanges();
            return Ok();
        }
    }
}