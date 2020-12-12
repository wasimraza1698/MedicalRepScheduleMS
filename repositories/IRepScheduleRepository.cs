using MedicalRepresentativeSchedule.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRepresentativeSchedule.repositories
{
    public interface IRepScheduleRepository
    {
        public List<Doctor> GetDoctorDetails();
        public List<RepresentativeDetails> GetRepresentativesDetails();
    }
}
