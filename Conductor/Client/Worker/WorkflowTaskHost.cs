using Conductor.Client.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Conductor.Client.Extensions
{
    public class WorkflowTaskHost
    {
        private static Dictionary<LogLevel, IHost> _hostByLogLevel;

        static WorkflowTaskHost()
        {
            _hostByLogLevel = new Dictionary<LogLevel, IHost>();
        }

        public static IHost GetWorkerHost(LogLevel logLevel = LogLevel.Information)
        {
            if (!_hostByLogLevel.ContainsKey(logLevel))
            {
                var host = CreateWorkerHost(ApiExtensions.GetConfiguration(), logLevel);
                _hostByLogLevel[logLevel] = host;
            }
            return _hostByLogLevel[logLevel];
        }

        public static IHost CreateWorkerHost(Configuration configuration, LogLevel logLevel = LogLevel.Information)
        {
            return new HostBuilder()
                .ConfigureServices(
                    (ctx, services) =>
                        {
                            services.AddConductorWorker(configuration);
                            services.WithHostedService();
                        }
                ).ConfigureLogging(
                    logging =>
                        {
                            logging.SetMinimumLevel(logLevel);
                            logging.AddConsole();
                        }
                ).Build();
        }

        public static IHost CreateWorkerHost(Configuration configuration, LogLevel logLevel = LogLevel.Information, params IWorkflowTask[] workers)
        {
            return new HostBuilder()
                .ConfigureServices(
                    (ctx, services) =>
                        {
                            services.AddConductorWorker(configuration);
                            foreach (var worker in workers)
                            {
                                services.AddConductorWorkflowTask(worker);
                            }
                            services.WithHostedService();
                        }
                ).ConfigureLogging(
                    logging =>
                        {
                            logging.SetMinimumLevel(logLevel);
                            logging.AddConsole();
                        }
                ).Build();
        }
    }
}
