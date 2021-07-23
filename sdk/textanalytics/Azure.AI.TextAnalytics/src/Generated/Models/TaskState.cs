// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TaskState. </summary>
    internal partial class TaskState
    {
        /// <summary> Initializes a new instance of TaskState. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        internal TaskState(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status)
        {
            LastUpdateDateTime = lastUpdateDateTime;
            Status = status;
        }

        /// <summary> Initializes a new instance of TaskState. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="taskName"></param>
        /// <param name="status"></param>
        internal TaskState(DateTimeOffset lastUpdateDateTime, string taskName, TextAnalyticsOperationStatus status)
        {
            LastUpdateDateTime = lastUpdateDateTime;
            TaskName = taskName;
            Status = status;
        }

        public DateTimeOffset LastUpdateDateTime { get; }
        public string TaskName { get; }
        public TextAnalyticsOperationStatus Status { get; }
    }
}
