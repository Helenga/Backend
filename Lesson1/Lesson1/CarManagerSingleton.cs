using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1
{
    public static class CarManagerSingleton
    {
        private static CarManager _carManager;

        public static CarManager CarManager()
        {
            if (_carManager == null)
            {
                _carManager = new CarManager();
                _carManager.Add(new Car(1, "Car1", 100));
                _carManager.Add(new Car(2, "Car2", 101));
            }
            return _carManager;
        }
    }
}
