// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVmware.Models
{
    /// <summary> Defines the resource properties. </summary>
    public partial class GuestAgentProfile
    {
        /// <summary> Initializes a new instance of GuestAgentProfile. </summary>
        public GuestAgentProfile()
        {
            ErrorDetails = new ChangeTrackingList<ErrorDetail>();
        }

        /// <summary> Initializes a new instance of GuestAgentProfile. </summary>
        /// <param name="vmUuid"> Specifies the VM&apos;s unique SMBIOS ID. </param>
        /// <param name="status"> The status of the hybrid machine agent. </param>
        /// <param name="lastStatusChange"> The time of the last status change. </param>
        /// <param name="agentVersion"> The hybrid machine agent full version. </param>
        /// <param name="errorDetails"> Details about the error state. </param>
        internal GuestAgentProfile(string vmUuid, StatusTypes? status, DateTimeOffset? lastStatusChange, string agentVersion, IReadOnlyList<ErrorDetail> errorDetails)
        {
            VmUuid = vmUuid;
            Status = status;
            LastStatusChange = lastStatusChange;
            AgentVersion = agentVersion;
            ErrorDetails = errorDetails;
        }

        /// <summary> Specifies the VM&apos;s unique SMBIOS ID. </summary>
        public string VmUuid { get; }
        /// <summary> The status of the hybrid machine agent. </summary>
        public StatusTypes? Status { get; }
        /// <summary> The time of the last status change. </summary>
        public DateTimeOffset? LastStatusChange { get; }
        /// <summary> The hybrid machine agent full version. </summary>
        public string AgentVersion { get; }
        /// <summary> Details about the error state. </summary>
        public IReadOnlyList<ErrorDetail> ErrorDetails { get; }
    }
}
