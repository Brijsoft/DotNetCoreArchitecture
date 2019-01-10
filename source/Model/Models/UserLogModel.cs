using DotNetCoreArchitecture.Model.Enums;
using System;

namespace DotNetCoreArchitecture.Model.Models
{
    public class UserLogModel
    {
        public UserLogModel()
        {
            DateTime = DateTime.Now;
        }

        public UserLogModel(long userId, LogType logType) : this()
        {
            UserId = userId;
            LogType = logType;
        }

        public UserLogModel(long userId, LogType logType, string content) : this(userId, logType)
        {
            Content = content;
        }

        public long UserLogId { get; set; }

        public long UserId { get; set; }

        public LogType LogType { get; set; }

        public string Content { get; set; }

        public DateTime DateTime { get; set; }
    }
}
