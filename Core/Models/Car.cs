using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Car
    {
        public int Id { get; set; }
        static int _id { get; set; }
        public string Name { get; set; }
        public double Speed { get; set; }

        public int CarCode { get; set; }


        public Car(int id, string name, double speed, int carcode)
        {
            Name = name;
            Speed = speed;
            CarCode = carcode;
            _id++;
            Id = _id;
        }
    }
}
