using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka:{0} Model Yıl:{1} Renk: {2} Günlük Ücret: {3} - {4} ",car.BrandId, car.ModelYear, car.ColorId, car.DailyPrice, car.Description);
            }
         }
    }
}
