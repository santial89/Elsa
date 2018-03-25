using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Lupi.Data.DataAccess;
using Lupi.Data.Entities;

namespace Lupi.Web.Api.Controllers
{
    public class BreedsController : ApiController
    {
        private LupiContext db = new LupiContext();

        // GET: api/Breeds
        public IQueryable<Breed> GetBreeds()
        {
            return db.Breeds;
        }

        // GET: api/Breeds/5
        [ResponseType(typeof(Breed))]
        public IHttpActionResult GetBreed(Guid id)
        {
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return NotFound();
            }

            return Ok(breed);
        }

        // PUT: api/Breeds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBreed(Guid id, Breed breed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != breed.id)
            {
                return BadRequest();
            }

            db.Entry(breed).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreedExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Breeds
        [ResponseType(typeof(Breed))]
        public IHttpActionResult PostBreed(Breed breed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Breeds.Add(breed);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (BreedExists(breed.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = breed.id }, breed);
        }

        // DELETE: api/Breeds/5
        [ResponseType(typeof(Breed))]
        public IHttpActionResult DeleteBreed(Guid id)
        {
            Breed breed = db.Breeds.Find(id);
            if (breed == null)
            {
                return NotFound();
            }

            db.Breeds.Remove(breed);
            db.SaveChanges();

            return Ok(breed);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BreedExists(Guid id)
        {
            return db.Breeds.Count(e => e.id == id) > 0;
        }
    }
}