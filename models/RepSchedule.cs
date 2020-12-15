using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRepresentativeSchedule.models
{
    public class RepSchedule
    {
        public string RepName{get; set;}
        public string DoctorName { get; set; }
        public string TreatingAilment { get; set; }
        public string Medicine { get; set; }
        public string MeetingSlot { get; set; }
        public string DateOfMeeting { get; set; }
        public int DoctorContactNumber { get; set; }

    }
}
