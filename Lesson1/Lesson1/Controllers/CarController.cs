using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers
{
    [Produces("application/json")]
    [Route("car")]
    public class CarController : Controller
    {
        public CarController()
        {
            _carManager = CarManagerSingleton.CarManager();
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetCarById(int id)
        {
            return Ok(_carManager.GetCarById(id));
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddCar([FromBody] Car car)
        {
            _carManager.Add(car);
            return Ok(_carManager.Count);
        }

        [HttpPut]
        [Route("update/{id}")]
        public IActionResult UpdateCar(int id, [FromBody] Car car)
        {
            var carToUpdate = _carManager.GetCarById(id);
            if (car.Id.Equals(id))
            {
                if (!car.Equals(carToUpdate))
                    _carManager.UpdateCar(carToUpdate, car);
                return Ok();
            }
            else
                return BadRequest();
        }

        private CarManager _carManager;
    }
}