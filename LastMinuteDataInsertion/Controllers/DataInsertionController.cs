using Models.LastMinute;
using Services.LastMinute;
using System.Collections.Generic;
using System.Web.Http;

namespace LastMinuteDataInsertion.Controllers
{
    public class DataInsertionController : ApiController
    {

        IServices services = new Services.LastMinute.Services();

        [Route("save_search")]
        public IHttpActionResult Insertsearch(List<Search> searches)
        {
            return Ok(services.SaveSearch(searches));
        }
    }
}
