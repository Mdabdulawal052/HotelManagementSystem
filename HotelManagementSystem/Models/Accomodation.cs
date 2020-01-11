﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Accomodation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int AccomodationPackageID { get; set; }
        public AccomodationPackage AccomodationPackage { get; set; }
    }
}
