// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of workflow trigger histories. </summary>
    internal partial class WorkflowTriggerHistoryListResult
    {
        /// <summary> Initializes a new instance of WorkflowTriggerHistoryListResult. </summary>
        internal WorkflowTriggerHistoryListResult()
        {
            Value = new ChangeTrackingList<WorkflowTriggerHistoryData>();
        }

        /// <summary> Initializes a new instance of WorkflowTriggerHistoryListResult. </summary>
        /// <param name="value"> A list of workflow trigger histories. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal WorkflowTriggerHistoryListResult(IReadOnlyList<WorkflowTriggerHistoryData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of workflow trigger histories. </summary>
        public IReadOnlyList<WorkflowTriggerHistoryData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
