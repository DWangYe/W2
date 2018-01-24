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
    /// <summary>
    /// 
    /// </summary>
    public class TestController : ApiController
    {
        [Dependency]
        public ITestService TestService { get; set; }
        
        //[HttpGet]
        //public string GetUserID(int id)
        //{
        //    return "value = "+id;
        //}
        /// <summary>
        /// 获取测试字符串
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string PostTestString()
        {
            return TestService.GetTestString();
        }
        /// <summary>
        /// 根据手机号查用户名
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public string GetUserNameByPhoneNumber(GetUserNameByPhoneNumberRequest request)
        {
            return "Hello " + TestService.GetUserNameByPhoneNumber(request.PhoneNumber) + " !";
        }

    }
}