using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AttributeRouting.Web.Http;
using UserManagement.Core.DataAccess;
using UserManagement.Core.Search;

namespace UserManagement.WebApi
{
    public class UserController : ApiController
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            if (userRepository == null)
            {
                throw new ArgumentNullException("userRepository");
            }

            this.userRepository = userRepository;
        }

        // Solution #1 - using POSTAttribute and a method name which does not start with "Get"
        //[POST("api/users", RouteName = "UserController.FetchUsers")]
        //public async Task<HttpResponseMessage> FetchUsers([FromBody] UserSearchCriteria searchCriteria)
        //{
        //    var searchResult = userRepository.Get(searchCriteria);
        //    return await Task<HttpResponseMessage>.Factory.StartNew(() => Request.CreateResponse(HttpStatusCode.OK, searchResult));
        //}

        // Solution #2 - using HttpRouteAttribute, HttpPostAttribute and a method name which starts with "Get"
        [HttpRoute("api/users", RouteName = "UserController.FetchUsers")]
        [HttpPost]
        public async Task<HttpResponseMessage> Get([FromBody] UserSearchCriteria searchCriteria)
        {
            var searchResult = userRepository.Get(searchCriteria);
            return await Task<HttpResponseMessage>.Factory.StartNew(() => Request.CreateResponse(HttpStatusCode.OK, searchResult));
        }
    }
}