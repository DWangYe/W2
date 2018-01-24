using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace WebApplication1.Help
{
    /// <summary>
    /// 记录日志类
    /// </summary>
    public class LogHelper
    {
        public static void WriteLog(Type t, Exception e)
        {
            ILog log = LogManager.GetLogger(t);
            log.Error("Error",e);
        }

        public static void WriteLog(Type t,string s)
        {
            ILog log = LogManager.GetLogger(t);
            log.Error(s);
        }
    }
}