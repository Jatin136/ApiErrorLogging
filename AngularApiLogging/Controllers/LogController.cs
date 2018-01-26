using AngularApiLogging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AngularApiLogging.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LogController : ApiController
    {
        /*
         * Write now this code directly takes error string to be logged from Frontend.
         * We can modify our code for taking LogEntry Model and then build the error string.
         */

        // POST: api/Log
        public bool Post([FromBody]string errorMessage)
        {
            // code for writing to database
            AngularLoggingEntities angularLoggingEntities = new AngularLoggingEntities();
            angularLoggingEntities.ApiLogs.Add(new ApiLog()
            {
                ErrorMessage = errorMessage
            });
            angularLoggingEntities.SaveChanges();
            return true;
        }

        public bool Delete([FromBody]string errorMessage)
        {
            // code for writing to database
            AngularLoggingEntities angularLoggingEntities = new AngularLoggingEntities();

            var apiLogs = angularLoggingEntities.ApiLogs;

            angularLoggingEntities.ApiLogs.RemoveRange(apiLogs);
            angularLoggingEntities.SaveChanges();
            return true;
        }
    }
}
