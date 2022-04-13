// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Resource group export result. </summary>
    public partial class ResourceGroupExportResult
    {
        /// <summary> Initializes a new instance of ResourceGroupExportResult. </summary>
        internal ResourceGroupExportResult()
        {
        }

        /// <summary> Initializes a new instance of ResourceGroupExportResult. </summary>
        /// <param name="template"> The template content. </param>
        /// <param name="error"> The template export error. </param>
        internal ResourceGroupExportResult(BinaryData template, ResponseError error)
        {
            Template = template;
            Error = error;
        }

        /// <summary> The template content. </summary>
        public BinaryData Template { get; }
        /// <summary> The template export error. </summary>
        public ResponseError Error { get; }
    }
}
