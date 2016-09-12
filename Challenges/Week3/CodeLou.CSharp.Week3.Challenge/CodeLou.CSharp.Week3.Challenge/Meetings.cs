using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLou.CSharp.Week3.Challenge
{
    public class Meetings : CalendarItemBase
    {
        // Meetings need to be assigned a start date and time, an end date and time, a location, and attendees. You can decide what data you need for attendees.
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }
        public int attendees { get; set; }
    }
}
