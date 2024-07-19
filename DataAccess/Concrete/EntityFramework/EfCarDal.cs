using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalSystemContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using RentalSystemContext context = new();
            var result = from c in context.Cars
                         join cl in context.Colors
                         on c.ColorId equals cl.ColorId
                         join b in context.Brands
                         on c.BrandId equals b.BrandId
                         select new CarDetailDto { BrandName = b.BrandName, CarName = c.CarName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice };
            return result.ToList();
        }
    }
}
