using MedicalRepresentativeSchedule.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRepresentativeSchedule.repositories 
{

    public class RepScheduleRepository : IRepScheduleRepository
    {
        private static List<Doctor> doctors;
        private static List<RepresentativeDetails> representatives;
        public RepScheduleRepository()
        {
            doctors = new List<Doctor>()
             {
               new Doctor { Name = "D1",Contact_Number=0987654321 , Treating_Ailment="Orthopedics"},
               new Doctor { Name = "D2",Contact_Number=0987654321 , Treating_Ailment="General"},
               new Doctor { Name = "D3",Contact_Number=0987654321 , Treating_Ailment="Gynecology"},
               new Doctor { Name = "D4",Contact_Number=0987654321 , Treating_Ailment="Orthopedics"},
               new Doctor { Name = "D5",Contact_Number=0987654321 , Treating_Ailment="General"},
               new Doctor { Name = "D6",Contact_Number=0987654321 , Treating_Ailment="Gynecology"},
             };

            representatives = new List<RepresentativeDetails>()
            {
                new RepresentativeDetails{RepresentativeName= "R1" },
                new RepresentativeDetails{RepresentativeName= "R2" },
                new RepresentativeDetails{RepresentativeName= "R3" }
            };


        }
        public List<Doctor> GetDoctorDetails()
        {
            return doctors;
        }
        public List<RepresentativeDetails> GetRepresentativesDetails()
        {
            return representatives;
        }

    }
        
    
}
