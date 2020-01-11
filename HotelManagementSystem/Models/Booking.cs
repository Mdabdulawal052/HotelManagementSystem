using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Number of Stay Night
        /// </summary>
        public int Duration { get; set; }

        public int AccomodationID { get; set; }
        public Accomodation Accomodation { get; set; }
    }
}
