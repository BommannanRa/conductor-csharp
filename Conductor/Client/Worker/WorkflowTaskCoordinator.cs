﻿using Conductor.Client.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conductor.Client.Worker
{
    internal class WorkflowTaskCoordinator : IWorkflowTaskCoordinator
    {
        private int concurrentWorkers;
        private IServiceProvider serviceProvider;
        private ILogger<WorkflowTaskCoordinator> logger;
        private HashSet<Type> workerDefinitions = new HashSet<Type>();
        private Configuration configuration;

        public WorkflowTaskCoordinator(IServiceProvider serviceProvider,
            ILogger<WorkflowTaskCoordinator> logger,
            Configuration configuration)
        {
            this.serviceProvider = serviceProvider;
            this.logger = logger;
            concurrentWorkers = configuration.ConcurrentWorkers;
            this.configuration = configuration;
        }

        public async Task Start()
        {
            logger.LogInformation("Starting WorkflowCoordinator");
            var pollers = new List<Task>();
            for (var i = 0; i < concurrentWorkers; i++)
            {
                var executor = serviceProvider.GetService(typeof(IWorkflowTaskExecutor)) as IWorkflowTaskExecutor;
                pollers.Add(executor.StartPoller(workerDefinitions.ToList()));
            }
            await Task.WhenAll(pollers);
        }

        public void RegisterWorker<T>(T task) where T : IWorkflowTask
        {
            workerDefinitions.Add(task.GetType());
        }

    }
}
