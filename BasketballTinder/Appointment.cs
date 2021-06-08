﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTinder
{
    public class Appointment
    {
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Terrain { get; set; }
        public int TerrainId { get; set; }
    }
}
