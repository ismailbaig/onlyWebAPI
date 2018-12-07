using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MS.AdapterInterface.Implementation;
using MS.AdapterInterface;

namespace MS.Controllers
{
    [RoutePrefix("api")]
    public class HomeAPIController : ApiController
    {

        private readonly IHomeAdapter _homeAdapter;

        public HomeAPIController(HomeAdapter homeAdapter)
        {
            _homeAdapter = homeAdapter;
        }

        [Route("home")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _homeAdapter.GetUserName());
        }
    }
}
