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
        private readonly IRepScheduleProvider _repScheduleProvider;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(RepScheduleController));
        public RepScheduleController(IRepScheduleProvider repSchedule)
        {
            this._repScheduleProvider = repSchedule;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DateTime startDate)
        {
            try
            {
                var res = await _repScheduleProvider.GetRepScheduleAsync(startDate);
                if (res != null)
                {
                    log.Info("returning schedule");
                    return new OkObjectResult(res);
                }
                else
                {
                    log.Error("schedule not received");
                    return NotFound("schedule not received");
                }
            }
            catch (Exception e)
            {
                log.Error("Error while scheduling - "+e.Message);
                return StatusCode(500);
            }
        }
    }
}
