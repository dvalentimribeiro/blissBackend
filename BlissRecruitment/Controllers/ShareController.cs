using Bliss.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Bliss.Controllers
{
    public class ShareController : ApiController
    {

        //Get data from query string
        // POST: api/Share?{destination_email}&{content_url}
        public async Task<IHttpActionResult> Post([FromUri]ViewModelShare share)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var destinationEmail = share.destination_email;
            var contentUrl = share.content_url;

            //TODO: Send an email to user
            return Ok();
        }
    }
}
