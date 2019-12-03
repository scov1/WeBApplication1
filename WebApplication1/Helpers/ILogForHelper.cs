using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApplication1.Helpers
{
    public interface ILogForHelper
    {
        void Warn(string message);
        void Error(string message, Exception ex);
    }

    public class Log4NetHelper : ILogForHelper
    {
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(Assembly.GetExecutingAssembly().FullName);

        public void Error(string message, Exception ex)
        {
            _log.Error(message, ex);
        }

        public void Warn(string message)
        {
            _log.Warn(message);
        }
    }
}