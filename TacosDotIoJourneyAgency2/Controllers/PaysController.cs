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
    public class PaysController : ApiController
    {
        public IHttpActionResult Get()
        {
            JourneyAgencyDb db = new JourneyAgencyDb();
            return Ok(db.Pays.ToList());
        }

        public IHttpActionResult Get(int id)
        {
            JourneyAgencyDb db = new JourneyAgencyDb();
            return Ok(db.Pays.FirstOrDefault(p => p.Id == id));
        }

        public IHttpActionResult Post(Pays pays)
        {
            JourneyAgencyDb db = new JourneyAgencyDb();
            db.Pays.Add(pays);
            db.SaveChanges();
            return Ok();
        }
    }
}