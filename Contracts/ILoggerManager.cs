using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts {
    public interface ILoggerManager {
        void LogInfo(string message);
        void LogWarn(string messsage);
        void LogDebug(string message);
        void LogError(string message);
    }
}
