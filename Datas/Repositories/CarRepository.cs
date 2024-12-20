using RentACar.Datas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Datas.Repositories
{
    internal class CarRepository : ICarRepository
    {
        private readonly DbContext _context;
        public CarRepository(DbContext context)
        {
            _context = context;
        }

        public int Add(Car car)
        {
            throw new NotImplementedException();
        }

        public int Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> SearchCars(Car car)
        {
            throw new NotImplementedException();
        }

        public int Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
