using System;
using System.Collections.Generic;
using System.Text;

namespace PicturePlinko
{
    public class LoggerEventArgs : EventArgs
    {
        private string _messageBody;
        private string _messageTitle;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messageTitle"></param>
        /// <param name="messageBody"></param>
        public LoggerEventArgs(string messageTitle, string messageBody)
        {
            this._messageTitle = messageTitle;
            this._messageBody = messageBody;
        }

        #region properties

        /// <summary>
        /// Message Title
        /// </summary>
        public string MessageTitle
        {
            get
            {
                return this._messageTitle;
            }

        }

        /// <summary>
        /// Message Body
        /// </summary>
        public string MessageBody
        {
            get
            {
                return this._messageBody;
            }
        }
       
        #endregion
    }
}
