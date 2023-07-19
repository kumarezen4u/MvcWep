using log4net;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc.FileLogger  
{
    public static class LogHelper
    {
        private static PatternLayout _layout = new PatternLayout();
        private const string log_Pattern = "%m";// "%d [%t] %-5p %m%n";
        private static string log_Path = @"C:\StreamLineSub\LogFiles\";// ConfigurationManager.AppSettings["LogSaveFolder"];
        private static string logFileSize = "10MB";
        private static string userName = "kumar";
        private static string loglockingModel = "MinimalLock";
        private static string logSubFolder = null;
        private static ILog logInfoFile = null;
        private static string loggerDate;
        private static string processName;
        private static ILog logErrorFile = null;
        private static ILog logExceptionFile = null;
        private static System.Diagnostics.StackTrace trace = null;

        public static string DefaultPattern
        {
            get { return log_Pattern; }
        }

        static LogHelper()
        {
            _layout.ConversionPattern = DefaultPattern;
            _layout.ActivateOptions();
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            hierarchy.Configured = true;
        }

        public static void LogInitiate()
        {
            try
            {
                loggerDate = DateTime.Now.ToString("yyyyMMdd");
                logInfoFile = AgentLogAddNamedLogger("_info.log");
                logInfoFile.Info("DATE|USER|MESSAGE|METHOD|EXCPETION" + Environment.NewLine);
            }
            catch (Exception)
            {
            }
        }


        private static ILog AgentLogAddNamedLogger(string name)
        {
            try
            {
                logSubFolder = DateTime.Now.Date.ToString("yyyy-MM-dd");
                Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
                Logger newLogger = hierarchy.GetLogger(name) as Logger;

                PatternLayout patternLayout = new PatternLayout();
                patternLayout.ConversionPattern = log_Pattern;
                patternLayout.ActivateOptions();

                RollingFileAppender roller = new RollingFileAppender();
                roller.Layout = patternLayout;
                roller.AppendToFile = true;
                roller.RollingStyle = RollingFileAppender.RollingMode.Size;
                roller.MaxSizeRollBackups = 100;
                roller.MaximumFileSize = logFileSize;
                // roller.LockingModel = new FileAppender.InterProcessLock();
                switch (loglockingModel)
                {
                    case "InterProcessLock":
                        roller.LockingModel = new FileAppender.InterProcessLock();
                        break;
                    case "ExclusiveLock":
                        roller.LockingModel = new FileAppender.ExclusiveLock();
                        break;
                    default:
                        roller.LockingModel = new FileAppender.MinimalLock();
                        break;
                }
                roller.StaticLogFileName = false;
                roller.File = log_Path + "/" + string.Concat(logSubFolder, name);

                roller.ActivateOptions();
                newLogger.AddAppender(roller);
            }
            catch (Exception ex)
            {
            }
            return LogManager.GetLogger(name);
        }

        public static void ErrorInfoLogInitiate()
        {
            try
            {
                loggerDate = DateTime.Now.ToString("yyyyMMdd");
                logExceptionFile = AgentLogAddNamedLogger("_exception.log");
                logExceptionFile.Info("DATE|LINE|METHOD|MESSAGE" + Environment.NewLine);
            }
            catch (Exception)
            {
            }
        }



        public static void Info(object logMsg)
        {
            logInfoFile.Info(string.Format(string.Format("{0}|{1}|{2}{3}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), userName, logMsg, Environment.NewLine)));
        }
        public static void Info(object logMsg, string methodName = "")
        {
            logInfoFile.Info(string.Format(string.Format("{0}|{1}|{2}{3}{4}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), userName, logMsg, methodName.Length > 0 ? ("|" + methodName) : "", Environment.NewLine)));
        }
        public static void Info(object logMsg, object userName)
        {
            logInfoFile.Info(string.Format(string.Format("{0}|{1}|{2}{3}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), userName, logMsg, Environment.NewLine)));
        }
        public static void Info(object logMsg, Exception ex = null)
        {
            logInfoFile.Info(string.Format(string.Format("{0}|{1}|{2}{3}{4}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), userName, logMsg, ex != null ? ("|" + ex.Message) : "", Environment.NewLine)));
        }
        public static void Info(object logMsg, string methodName = "", Exception ex = null)
        {
            logInfoFile.Info(string.Format(string.Format("{0}|{1}|{2}{3}{4}{5}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), userName, logMsg, methodName.Length > 0 ? ("|" + methodName) : "", ex != null ? ("|" + ex.Message) : "", Environment.NewLine)));
        }



        public static void LogException(Exception ex)
        {
            ErrorInfoLogInitiate();
            trace = new System.Diagnostics.StackTrace(ex, true);
            logExceptionFile.Error(string.Format("{0}|{1}|{2}|{3}|{4}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), trace.GetFrame(4).GetFileLineNumber(), trace.GetFrame(4).GetMethod(), ex.Message, Environment.NewLine));
            logExceptionFile.Error(string.Format("StackTrace Message : {0}", trace));
            //  LogHelper.LogInfo(string.Format(LoggerMessage.ExceptionTrace, trace.GetFrame(0).GetFileLineNumber(), trace.GetFrame(0).GetMethod(), ex.Message));
        }


        public static void Debug(Type t, Guid logKey, string log, Exception ex = null)
        {

        }
        public static void Info(Type t, Guid logKey, string log, Exception ex = null)
        {

        }
        public static void Fatal(Type t, Guid logKey, string log, Exception ex = null)
        {

        }
        public static void Warn(Type t, Guid logKey, string log, Exception ex = null)
        {

        }
    }
}