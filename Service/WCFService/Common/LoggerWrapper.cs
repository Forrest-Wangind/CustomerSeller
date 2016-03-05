using log4net;
using System.Collections.Generic;
using System.Reflection;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Common.Log
{
    /// <summary>
    /// <see cref="EM.Passport.Common.ILoggerWrapper"/>
    /// </summary>
    public class LoggerWrapper : Common.Log.ILoggerWrapper
    {
        private ILog log = null;
        private static object lockObj = new object();
        private static string defaultLoggerName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        private static readonly Dictionary<string, ILoggerWrapper> loggerDic = new Dictionary<string, ILoggerWrapper>();

        /// <summary>
        /// 默认的日志实例
        /// </summary>
        /// <returns>日志实例对象</returns>
        public static ILoggerWrapper Instance()
        {
            return Instance(defaultLoggerName);
        }

        /// <summary>
        /// 指定日志实例
        /// </summary>
        /// <returns>指定的日志实例对象</returns>
        public static ILoggerWrapper Instance(string loggerName)
        {
            ILoggerWrapper logger = null;
            if (!string.IsNullOrEmpty(loggerName))
            {
                if (loggerDic.ContainsKey(loggerName))
                {
                    logger = loggerDic[loggerName];
                }
                else
                {
                    lock (lockObj)
                    {
                        if (!loggerDic.ContainsKey(loggerName))
                        {
                            logger = new LoggerWrapper(loggerName);
                            loggerDic.Add(loggerName, logger);
                        }
                    }
                }
            }

            return logger;
        }

        /// <summary>
        /// 私有化默认构造函数
        /// </summary>
        private LoggerWrapper(string loggerName)
        {
            log = log4net.LogManager.GetLogger(loggerName);
        }

        /// <summary>
        /// <see cref="EM.Passport.Common.ILoggerWrapper.LogError"/>
        /// </summary>
        public void LogError(object messageObj)
        {
            log.Error(messageObj.ToString());
        }

        /// <summary>
        /// <see cref="EM.Passport.Common.ILoggerWrapper.LogWarn"/>
        /// </summary>
        public void LogWarn(object messageObj)
        {
            log.Warn(messageObj.ToString());
        }

        /// <summary>
        /// <see cref="EM.Passport.Common.ILoggerWrapper.LogInfo"/>
        /// </summary>
        public void LogInfo(object messageObj)
        {
            log.Info(messageObj.ToString());
        }

        /// <summary>
        /// <see cref="EM.Passport.Common.ILoggerWrapper.LogDebug"/>
        /// </summary>
        public void LogDebug(object messageObj)
        {
            log.Debug(messageObj.ToString());
        }
    }
}
