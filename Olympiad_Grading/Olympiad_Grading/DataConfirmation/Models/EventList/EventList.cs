using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olympiad_Grading.DataConfirmation.Models.EventList
{
    public class EventList
    {
      
        public string User { get; set; }

        public List<OlympiadEvent> Events { get; set; }

    }
}
