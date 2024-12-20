using RentACar.Datas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Datas.Repositories
{
    internal interface IUserRepository
    {
        int Add(User user);
        int Update(User user);
        int Delete(User user);
        User GetById(int id);
        User GetByEMail(string email);
        List<User> GetAll();
    }
}
