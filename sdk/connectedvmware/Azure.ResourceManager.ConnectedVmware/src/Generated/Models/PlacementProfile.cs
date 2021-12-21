// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVmware.Models
{
    /// <summary> Defines the resource properties. </summary>
    public partial class PlacementProfile
    {
        /// <summary> Initializes a new instance of PlacementProfile. </summary>
        public PlacementProfile()
        {
        }

        /// <summary> Initializes a new instance of PlacementProfile. </summary>
        /// <param name="resourcePoolId"> Gets or sets the ARM Id of the resourcePool resource on which this virtual machine will deploy. </param>
        /// <param name="clusterId"> Gets or sets the ARM Id of the cluster resource on which this virtual machine will deploy. </param>
        /// <param name="hostId"> Gets or sets the ARM Id of the host resource on which this virtual machine will deploy. </param>
        /// <param name="datastoreId"> Gets or sets the ARM Id of the datastore resource on which the data for the virtual machine will be kept. </param>
        internal PlacementProfile(string resourcePoolId, string clusterId, string hostId, string datastoreId)
        {
            ResourcePoolId = resourcePoolId;
            ClusterId = clusterId;
            HostId = hostId;
            DatastoreId = datastoreId;
        }

        /// <summary> Gets or sets the ARM Id of the resourcePool resource on which this virtual machine will deploy. </summary>
        public string ResourcePoolId { get; set; }
        /// <summary> Gets or sets the ARM Id of the cluster resource on which this virtual machine will deploy. </summary>
        public string ClusterId { get; set; }
        /// <summary> Gets or sets the ARM Id of the host resource on which this virtual machine will deploy. </summary>
        public string HostId { get; set; }
        /// <summary> Gets or sets the ARM Id of the datastore resource on which the data for the virtual machine will be kept. </summary>
        public string DatastoreId { get; set; }
    }
}
