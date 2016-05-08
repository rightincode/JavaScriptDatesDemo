using System;
using System.Web.Http;

namespace JsDatesAPI.Controllers
{
    [RoutePrefix("api/jsdates")]
    public class JsDatesController : ApiController
    {
        [Route(""), HttpGet]
        public DateTime GetDate()
        {
            return DateTime.Now;
        }

        [Route("utc"), HttpGet]
        public DateTime GetUtcDate()
        {
            return DateTime.UtcNow;
        }

        [Route("save"), HttpPost]
        public string SaveDate([FromUri] DateTime postedDate)
        {
            string postedDateStr = postedDate.ToString("G");

            return postedDateStr;
        }

        [Route("saveandreturn"), HttpPost]
        public DateTime SaveAndReturnDate([FromUri] DateTime postedDate)
        {
            return postedDate;
        }
    }
}
