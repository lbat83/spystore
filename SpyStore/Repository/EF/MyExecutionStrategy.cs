﻿using System;
using Microsoft.EntityFrameworkCore.Storage;

namespace Repository.EF
{
    public class MyExecutionStrategy : ExecutionStrategy
    {
        public MyExecutionStrategy(ExecutionStrategyDependencies dependencies) :
            base(dependencies, ExecutionStrategy.DefaultMaxRetryCount, ExecutionStrategy.DefaultMaxDelay)
        {

        }
        public MyExecutionStrategy(ExecutionStrategyDependencies dependencies, int maxRetryCount, TimeSpan maxRetryDelay) :
            base(dependencies, maxRetryCount, maxRetryDelay)
        {

        }
        protected override bool ShouldRetryOn(Exception exception)
        {
            return true;
        }
    }
}
