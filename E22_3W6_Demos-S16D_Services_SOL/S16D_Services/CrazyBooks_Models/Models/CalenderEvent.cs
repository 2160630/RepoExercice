﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class CalenderEvent
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateEvent { get; set; }
        public string Title { get; set; }
        public string ShortDesc { get; set; }
    }
}
