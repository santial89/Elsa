﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lupi.Data.Entities;
using Lupi.UnitTest;

namespace Lupi.Web.Api.Controllers
{
    public class BreedController : ApiController
    {
        private static List<Breed> breeds = new List<Breed>();
        // GET: api/Breed
        public IHttpActionResult Get()
        {
            return Ok(breeds);
        }

        // GET: api/Breed/5
        public IHttpActionResult Get([FromUri] Guid id)
        {
            var breed = breeds.Find(b => b.id == id);
            if(breed == null)
            {
                return NotFound();
            }else
            return Ok(breed);
        }

        // POST: api/Breed
        public IHttpActionResult Post([FromBody] Breed breed)
        {
            breed.id = Guid.NewGuid();
            breeds.Add(breed);
            return CreatedAtRoute("DefaultApi",new {breed.id},breed);
        }

        // PUT: api/Breed/5
        public IHttpActionResult Put([FromUri] Guid id, [FromBody] Breed updateBreed)
        {
            var breed = breeds.Find(b => b.id == id);
            if(breed == null)
            {
                return NotFound();
            }
            updateBreed.id = breed.id;
            breeds.Remove(breed);
            breeds.Add(updateBreed);
            return Ok();

        }

        // DELETE: api/Breed/5
        public IHttpActionResult Delete([FromUri] Guid id)
        {
            var breed = breeds.Find(b => b.id == id);
            if(breed == null)
            {
                return NotFound();
            }
            breeds.Remove(breed);
            return Ok();
        }

        [Route("api/BReeds/(id:guid)/collars")]
        [HttpPost]
        public IHttpActionResult PostCollar([FromUri] Guid id, [FromBody] Collar collar)
        {
            collar.Id = Guid.NewGuid();
            var breed = breeds.Find(b => b.id == id);
            if (breed == null)
            {
                return NotFound();
            }
            //breeds.Collars.Add(collar);
            return CreatedAtRoute("GetCollarsById",new {breedid = breed.id, collarid = collar.Id}, collar);
        }


        [Route("api/Breeds/{breedid:guid}/collarid:guid")]
        public IHttpActionResult Get([FromUri] Guid breedid, [FromUri] Guid collarid)
        {
            var breed = breeds.Find(b => b.id == breedid);
            if(breed == null)
            {
                return NotFound();
            }

            //var collar = breed.collars.Find(char => char.id == collarid);
          //  if(collar == null)
            //{
              //  return NotFound();
           // }

            return Ok();

        }

    }
}
