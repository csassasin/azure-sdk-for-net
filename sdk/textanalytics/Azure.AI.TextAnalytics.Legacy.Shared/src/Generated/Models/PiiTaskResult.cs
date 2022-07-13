// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The PiiTaskResult. </summary>
    internal partial class PiiTaskResult
    {
        /// <summary> Initializes a new instance of PiiTaskResult. </summary>
        internal PiiTaskResult()
        {
        }

        /// <summary> Initializes a new instance of PiiTaskResult. </summary>
        /// <param name="results"></param>
        internal PiiTaskResult(PiiResult results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public PiiResult Results { get; }
    }
}
