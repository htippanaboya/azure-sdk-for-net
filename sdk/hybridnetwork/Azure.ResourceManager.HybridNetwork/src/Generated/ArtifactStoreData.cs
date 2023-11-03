// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing the ArtifactStore data model.
    /// Artifact store properties.
    /// </summary>
    public partial class ArtifactStoreData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ArtifactStoreData. </summary>
        /// <param name="location"> The location. </param>
        public ArtifactStoreData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ArtifactStoreData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> ArtifactStores properties. </param>
        internal ArtifactStoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ArtifactStorePropertiesFormat properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> ArtifactStores properties. </summary>
        public ArtifactStorePropertiesFormat Properties { get; set; }
    }
}
