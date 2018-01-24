using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace WebApplication1
{
    public class BootStrapper
    {
        /// <summary>
        /// 获取容器-注册依赖关系
        /// </summary>
        /// <returns></returns>
        public static void Initialise()
        {
            var container = new UnityContainer();
            //注册
            container.RegisterType<ITestService, TestService>();
            //MVC注入
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            //WebApi 注入
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}