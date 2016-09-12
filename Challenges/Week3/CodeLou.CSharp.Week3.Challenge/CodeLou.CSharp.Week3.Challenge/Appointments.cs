﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLou.CSharp.Week3.Challenge
{
    public class Appointments : CalendarItemBase
    {
        // Appointments need to be assigned a start date and time, an end date and time, and a location.
        var myAppointment = new Appointments(); 

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }

    }
}