// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the DataCollectionRule data model. </summary>
    public partial class DataCollectionRuleData : TrackedResource
    {
        /// <summary> Initializes a new instance of DataCollectionRuleData. </summary>
        /// <param name="location"> The location. </param>
        public DataCollectionRuleData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of DataCollectionRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Resource properties. </param>
        /// <param name="kind"> The kind of the resource. </param>
        /// <param name="etag"> Resource entity tag (ETag). </param>
        internal DataCollectionRuleData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DataCollectionRuleProperties properties, KnownDataCollectionRuleResourceKind? kind, string etag) : base(id, name, type, systemData, tags, location)
        {
            Properties = properties;
            Kind = kind;
            Etag = etag;
        }

        /// <summary> Resource properties. </summary>
        public DataCollectionRuleProperties Properties { get; set; }
        /// <summary> The kind of the resource. </summary>
        public KnownDataCollectionRuleResourceKind? Kind { get; set; }
        /// <summary> Resource entity tag (ETag). </summary>
        public string Etag { get; }
    }
}
