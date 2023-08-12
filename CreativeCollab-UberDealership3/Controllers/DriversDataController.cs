using CreativeCollab_UberDealership3.Models;
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
using System.Web.Mvc;
using System.Web.Script.Serialization;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;
//using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
//using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace CreativeCollab_UberDealership3.Controllers
{
    public class DriversDataController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/DriversData
        [HttpGet]
        [ResponseType(typeof(DriverDto))]
        public IHttpActionResult GetDrivers()
        {

            List<Driver> Drivers = db.Drivers.ToList();
            List<DriverDto> DriverDto = new List<DriverDto>();
            Drivers.ForEach(c => DriverDto.Add(new DriverDto()
            {
                DriverID = c.DriverID,
                DriverFirstName = c.DriverFirstName,
                DriverLastName = c.DriverLastName,

                Year = c.Cars.Year,
                Price = c.Cars.Price,
                Mileage = c.Cars.Mileage,

                //CarModelName = c.CarModels.ModelName,
                //CarMakeName = c.CarModels.Make,

                //DealerName = c.Dealers.DealerName
            }));

            return Ok(DriverDto);
        }

        // GET: api/DriversData/5
        [ResponseType(typeof(Driver))]
        [HttpGet]
        public IHttpActionResult GetDriver(int id)
        {
            Driver driver = db.Drivers.Find(id);


            DriverDto DriverDto = new DriverDto()
            {
                DriverID = driver.DriverID,
                DriverFirstName = driver.DriverFirstName,
                DriverLastName = driver.DriverLastName,
                Year = driver.Cars.Year,
                Price = driver.Cars.Price,
                Mileage = driver.Cars.Mileage,

                //CarModelName = c.CarModels.ModelName,
                //CarMakeName = c.CarModels.Make,

                //DealerName = c.Dealers.DealerName
            };
            if (driver == null)
            {
                return NotFound();
            }
            return Ok(DriverDto);
        }

        // POST: api/DriversData/UpdateDriver/3
        [HttpPost]
        [ResponseType(typeof(void))]
        public IHttpActionResult UpdateDriver(int id, Driver driver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != driver.DriverID)
            {
                return BadRequest();
            }

            db.Entry(driver).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverExists(id))
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

        // POST: api/DriversData
        [ResponseType(typeof(Driver))]
        [HttpPost]
        public IHttpActionResult AddDriver(Driver driver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Drivers.Add(driver);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = driver.DriverID }, driver);
        }

        // DELETE: api/DriversData/5
        [ResponseType(typeof(Driver))]
        [HttpPost]
        public IHttpActionResult DeleteDriver(int id)
        {
            Driver driver = db.Drivers.Find(id);
            if (driver == null)
            {
                return NotFound();
            }

            db.Drivers.Remove(driver);
            db.SaveChanges();

            return Ok(driver);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DriverExists(int id)
        {
            return db.Drivers.Count(e => e.DriverID == id) > 0;
        }
    }
}


