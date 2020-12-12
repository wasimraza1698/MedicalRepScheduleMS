using log4net.Config;
using MedicalRepresentativeSchedule.models;
using MedicalRepresentativeSchedule.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRepresentativeSchedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepScheduleController : ControllerBase
    {
        private IRepScheduleProvider irepschedule;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(RepScheduleController));
        public RepScheduleController(IRepScheduleProvider _irepschedule)
        {
            this.irepschedule = _irepschedule;
        }


        [HttpGet]
        public async Task<IActionResult> Get(DateTime startdate)
        {
            var res = await irepschedule.GetRepScheduleAsync(startdate);
            log.Info("returning schedule");
            return new OkObjectResult(res);
        }


    }
}
