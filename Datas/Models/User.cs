using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Datas.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; } 
        public string Role { get; set; } 
        public string DrivingLicenseNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Car> RentedCars { get; set; }
    }

}
