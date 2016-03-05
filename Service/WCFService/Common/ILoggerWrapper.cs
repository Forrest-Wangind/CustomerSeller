
namespace Common.Log
{
    /// <summary>
    /// 日志工具类接口
    /// </summary>
    public interface ILoggerWrapper
    {
        /// <summary>
        /// 打印错误日志
        /// </summary>
        /// <param name="messageObj">消息对象</param>
        void LogError(object messageObj);

        /// <summary>
        /// 打印警告日志
        /// </summary>
        /// <param name="messageObj">消息对象</param>
        void LogWarn(object messageObj);

        /// <summary>
        /// 打印信息日志
        /// </summary>
        /// <param name="messageObj">消息对象</param>
        void LogInfo(object messageObj);

        /// <summary>
        /// 打印调试日志
        /// </summary>
        /// <param name="messageObj">消息对象</param>
        void LogDebug(object messageObj);
    }
}
