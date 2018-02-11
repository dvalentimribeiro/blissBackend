using Bliss.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Bliss.Controllers
{
    public class HealthController : ApiController
    {
     
        // GET: api/Health/
        public string Get()
        {
            Thread.Sleep(200);
            return "ok";
        }

    }
}
