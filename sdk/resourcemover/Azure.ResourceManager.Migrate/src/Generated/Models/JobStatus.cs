// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the job status. </summary>
    public partial class JobStatus
    {
        /// <summary> Initializes a new instance of JobStatus. </summary>
        internal JobStatus()
        {
        }

        /// <summary> Initializes a new instance of JobStatus. </summary>
        /// <param name="jobName"> Defines the job name. </param>
        /// <param name="jobProgress"> Gets or sets the monitoring job percentage. </param>
        internal JobStatus(JobName? jobName, string jobProgress)
        {
            JobName = jobName;
            JobProgress = jobProgress;
        }

        /// <summary> Defines the job name. </summary>
        public JobName? JobName { get; }
        /// <summary> Gets or sets the monitoring job percentage. </summary>
        public string JobProgress { get; }
    }
}
