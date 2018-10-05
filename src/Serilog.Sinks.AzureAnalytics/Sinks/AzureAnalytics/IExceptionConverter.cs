using System;

namespace Serilog.Sinks.AzureAnalytics
{
    public interface IExceptionConverter
    {
        object Convert(Exception exception);
    }
}
