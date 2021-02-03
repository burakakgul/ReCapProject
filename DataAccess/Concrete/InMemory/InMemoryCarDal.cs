using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //Naming Convention
        List<Car> _cars;
        List<Brand> _brand;
        List<Color> _color;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=3,ModelYear=2011,DailyPrice=200,Description="Ford Focus"},
                new Car{Id=2,BrandId=2,ColorId=1,ModelYear=2000,DailyPrice=100,Description="Volkswagen Bora"},
                new Car{Id=3,BrandId=3,ColorId=3,ModelYear=2004,DailyPrice=50,Description="Fiat Albea"}

            };
            _brand = new List<Brand>
            {
                new Brand{BrandId = 1,BrandName = "Ford"},
                new Brand{BrandId = 2,BrandName = "Volkwagen"},
                new Brand{BrandId = 3,BrandName = "Fiat"}
            };
            _color = new List<Color>
            {
                new Color{ColorId = 1,ColorName = "Beyaz"},
                new Color{ColorId = 2,ColorName = "Siyah"},
                new Color{ColorId = 3,ColorName = "Gri"}

            };
        }

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
