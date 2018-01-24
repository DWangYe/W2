using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Unity.Attributes;
using WebApplication1.Models;

namespace WebApplication1.Controllers.Api
{
    public class Test2Controller : ApiController
    {
        [Dependency]
        public ITestService TestService { get; set; }

        [HttpPost]
        public string GetUserNameByPhoneNumber(GetUserNameByPhoneNumberRequest request)
        {
            return "Hello " + TestService.GetUserNameByPhoneNumber(request.PhoneNumber) + " !";
        }
    }
}
