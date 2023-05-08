using Conductor.Api;
using Conductor.Executor;
using Conductor.Client.Authentication;
using System;
using System.Diagnostics;

namespace Conductor.Client.Extensions
{
    public class ApiExtensions
    {
        private const string ENV_ROOT_URI = "CONDUCTOR_SERVER_URL";
        private const string ENV_KEY_ID = "KEY";
        private const string ENV_SECRET = "SECRET";

        private static Configuration _configuration = null;

        static ApiExtensions()
        {
            _configuration = new Configuration()
            {
                Timeout = 30 * 1000,
                BasePath = GetEnvironmentVariable(ENV_ROOT_URI),
                AuthenticationSettings = new OrkesAuthenticationSettings(
                    GetEnvironmentVariable(ENV_KEY_ID),
                    GetEnvironmentVariable(ENV_SECRET)
                )
            };
        }

        public static WorkflowExecutor GetWorkflowExecutor()
        {
            return new WorkflowExecutor(
                metadataClient: GetClient<MetadataResourceApi>(),
                workflowClient: GetClient<WorkflowResourceApi>()
            );
        }

        public static T GetClient<T>() where T : IApiAccessor, new()
        {
            return _configuration.GetClient<T>();
        }

        public static Configuration GetConfiguration()
        {
            return _configuration;
        }

        private static string GetEnvironmentVariable(string variable)
        {
            string value = Environment.GetEnvironmentVariable(variable);
            Debug.Assert(value != null);
            return value;
        }
    }
}
