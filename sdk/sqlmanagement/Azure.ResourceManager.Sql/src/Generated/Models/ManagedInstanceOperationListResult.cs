// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The response to a list managed instance operations request. </summary>
    internal partial class ManagedInstanceOperationListResult
    {
        /// <summary> Initializes a new instance of ManagedInstanceOperationListResult. </summary>
        internal ManagedInstanceOperationListResult()
        {
            Value = new ChangeTrackingList<ManagedInstanceOperationData>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceOperationListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedInstanceOperationListResult(IReadOnlyList<ManagedInstanceOperationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstanceOperationData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
