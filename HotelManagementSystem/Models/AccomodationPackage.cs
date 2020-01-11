using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class AccomodationPackage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NoOfRoom { get; set; }
        public decimal FeeForNight { get; set; }

        public int AccomodationTypeID { get; set; }
        public AccomodationType AccomodationType { get; set; }
    }
}
