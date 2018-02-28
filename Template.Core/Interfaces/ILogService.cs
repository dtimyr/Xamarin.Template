using System;

namespace Template.Core.Interfaces
{
    public interface ILogService
    {
        void Initialize();
        void LogException(Exception exception, string method);
    }
}