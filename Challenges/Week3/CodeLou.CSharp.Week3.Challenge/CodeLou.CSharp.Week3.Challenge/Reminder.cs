﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLou.CSharp.Week3.Challenge
{
	public class Reminder: CalendarItemBase
	{
        // Reminders need to be assigned a start date and time.
        public DateTime StartDateTime { get; set; }
        public string Location { get; set; }
    }
}
