using MedicalRepresentativeSchedule.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRepresentativeSchedule.Providers
{
    public interface IRepScheduleProvider
    {
        public  Task<List<RepSchedule>> GetRepScheduleAsync(DateTime startdate);

    }
}
