// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An properties abstract Query item for entity
    /// </summary>
    public partial class EntityQueryItemProperties
    {
        /// <summary>
        /// Initializes a new instance of the EntityQueryItemProperties class.
        /// </summary>
        public EntityQueryItemProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityQueryItemProperties class.
        /// </summary>
        /// <param name="dataTypes">Data types for template</param>
        /// <param name="inputEntityType">The type of the entity. Possible
        /// values include: 'Account', 'Host', 'File', 'AzureResource',
        /// 'CloudApplication', 'DNS', 'FileHash', 'IP', 'Malware', 'Process',
        /// 'RegistryKey', 'RegistryValue', 'SecurityGroup', 'URL',
        /// 'IoTDevice', 'SecurityAlert', 'HuntingBookmark', 'MailCluster',
        /// 'MailMessage', 'Mailbox', 'SubmissionMail'</param>
        /// <param name="requiredInputFieldsSets">Data types for
        /// template</param>
        /// <param name="entitiesFilter">The query applied only to entities
        /// matching to all filters</param>
        public EntityQueryItemProperties(IList<EntityQueryItemPropertiesDataTypesItem> dataTypes = default(IList<EntityQueryItemPropertiesDataTypesItem>), string inputEntityType = default(string), IList<IList<string>> requiredInputFieldsSets = default(IList<IList<string>>), object entitiesFilter = default(object))
        {
            DataTypes = dataTypes;
            InputEntityType = inputEntityType;
            RequiredInputFieldsSets = requiredInputFieldsSets;
            EntitiesFilter = entitiesFilter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data types for template
        /// </summary>
        [JsonProperty(PropertyName = "dataTypes")]
        public IList<EntityQueryItemPropertiesDataTypesItem> DataTypes { get; set; }

        /// <summary>
        /// Gets or sets the type of the entity. Possible values include:
        /// 'Account', 'Host', 'File', 'AzureResource', 'CloudApplication',
        /// 'DNS', 'FileHash', 'IP', 'Malware', 'Process', 'RegistryKey',
        /// 'RegistryValue', 'SecurityGroup', 'URL', 'IoTDevice',
        /// 'SecurityAlert', 'HuntingBookmark', 'MailCluster', 'MailMessage',
        /// 'Mailbox', 'SubmissionMail'
        /// </summary>
        [JsonProperty(PropertyName = "inputEntityType")]
        public string InputEntityType { get; set; }

        /// <summary>
        /// Gets or sets data types for template
        /// </summary>
        [JsonProperty(PropertyName = "requiredInputFieldsSets")]
        public IList<IList<string>> RequiredInputFieldsSets { get; set; }

        /// <summary>
        /// Gets or sets the query applied only to entities matching to all
        /// filters
        /// </summary>
        [JsonProperty(PropertyName = "entitiesFilter")]
        public object EntitiesFilter { get; set; }

    }
}
