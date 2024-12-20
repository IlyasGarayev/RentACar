using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Datas.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public string FuelType { get; set; }
        public decimal PricePerDay { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Status { get; set; } 
        public int Mileage { get; set; }
        public DateTime CreatedDate { get; set; }
        public User RentedBy { get; set; }


    }

}
