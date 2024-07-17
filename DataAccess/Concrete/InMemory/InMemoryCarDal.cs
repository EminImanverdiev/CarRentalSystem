using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{BrandId=1,CarId=1,ColorId=1,Description="This is a good driving tool",ModelYear=new DateTime(2005, 8, 29)},
                new Car{BrandId=2,CarId=2,ColorId=2,Description="This is a good driving tool",ModelYear=new DateTime(2009, 3, 1)},
                new Car{BrandId=2,CarId=3,ColorId=3,Description="This is a good driving tool",ModelYear=new DateTime(2010, 2, 7)},
                new Car{BrandId=1,CarId=4,ColorId=4,Description="This is a good driving tool",ModelYear=new DateTime(2015, 7, 19)},
                new Car{BrandId=1,CarId=5,ColorId=5,Description="This is a good driving tool",ModelYear=new DateTime(2000, 4, 9)},
            };
        }

        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.CarId == id);
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            if (CarToUpdate!=null)
            {
                CarToUpdate.ModelYear = car.ModelYear;
                CarToUpdate.ColorId = car.ColorId;
                CarToUpdate.Description = car.Description;
                CarToUpdate.BrandId = car.BrandId;
            }
        }
    }
}
