using RentACar.Datas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Datas.Repositories
{
    internal interface ICarRepository
    {
        int Add(Car car);
        int Update(Car car);
        int Delete(Car car);
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> SearchCars(Car car);
    }
}
