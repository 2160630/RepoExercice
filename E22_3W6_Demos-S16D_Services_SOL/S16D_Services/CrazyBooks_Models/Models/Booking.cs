﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Event { get; set; }
        public int CalenderId { get; set; }
        public CalenderEvent calenderEvent { get; set; }
    }
}
