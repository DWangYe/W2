using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Attributes;
using WebApplication1.Help;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public ITestService TestService { get; set; }
        public ActionResult Index()
        {
            try
            {
                ViewBag.Title = "Home Page";
                ViewData.Add("test", TestService.GetUserNameByPhoneNumber("15737340456"));
                throw new Newtonsoft.Json.JsonReaderException();
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(GetType(), e);
            }
            return View();
        }
    }
}
