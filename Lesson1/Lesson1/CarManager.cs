using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1
{
    public class CarManager
    {
        public CarManager()
        {
            _cars = new HashSet<Car>();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public Car GetCarById(int id)
        {
            return _cars.SingleOrDefault(car => car.Id.Equals(id));
        }

        public void UpdateCar(Car carToUpdate, Car car)
        {
            _cars.Remove(carToUpdate);
            _cars.Add(car);
        }

        private HashSet<Car> _cars;
        public int Count => _cars.Count;
    }
}
