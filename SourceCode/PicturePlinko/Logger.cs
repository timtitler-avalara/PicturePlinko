using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Logging;


namespace PicturePlinko
{
    /// <summary>
    /// Generates Log Files for Script Runner
    /// </summary>
    public static class Logger
    {
        private static Microsoft.Practices.EnterpriseLibrary.Common.Configuration.IConfigurationSource source = new Microsoft.Practices.EnterpriseLibrary.Common.Configuration.SystemConfigurationSource();
        private static LogWriterFactory factory = new LogWriterFactory(source);
        static readonly LogWriter _logWriter = factory.Create();

        /// <summary>
        /// Logs Message
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        public static void LogMessage(string title, string message)
        {
            LogEntry entry = new LogEntry();
            entry.Title = "(" + System.DateTime.Now.ToShortTimeString() + ") " + title;
            entry.Message = message;

            _logWriter.Write(entry);
        }
    }
}
