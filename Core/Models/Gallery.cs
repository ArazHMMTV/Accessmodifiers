using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }

        Car[] Cars = { };

        public Gallery(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
        }

        public void ShowAllCars()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($" Name:{car.Name} Speed:{car.Speed} CarCode:{car.CarCode}");
            }
        }
        public Car[] GetAllCars()
        {
            return Cars;
        }


        public Car[] FindCarById(int id)
        {
            Car[] Cars1 = new Car[] { };
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Id == id)
                {
                    Array.Resize(ref Cars1, Cars1.Length + 1);
                    Cars1[Cars1.Length - 1] = Cars[i];
                }
            }
            return Cars1;
        }


        public Car[] FindCarByCarCode(int carcode)
        {
            Car[] Cars2 = new Car[] { };
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].CarCode == carcode)
                {
                    Array.Resize(ref Cars2, Cars2.Length + 1);
                    Cars2[Cars2.Length - 1] = Cars[i];
                }
            }
            return Cars2;
        }
        public Car[] FindCarsBySpeedInterval(int min, int max)
        {
            Car[] foundCars = new Car[0];

            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Speed >= min && Cars[i].Speed <= max)
                {

                    Array.Resize(ref foundCars, foundCars.Length + 1);
                    foundCars[foundCars.Length - 1] = Cars[i];
                }
            }

            return foundCars;
        }
    }
}
