// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotCentral.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the SKU of the IoT Central application.
    /// </summary>
    public partial class AppSkuInfo
    {
        /// <summary>
        /// Initializes a new instance of the AppSkuInfo class.
        /// </summary>
        public AppSkuInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppSkuInfo class.
        /// </summary>
        /// <param name="name">The name of the SKU. Possible values include:
        /// 'ST0', 'ST1', 'ST2'</param>
        public AppSkuInfo(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the SKU. Possible values include: 'ST0',
        /// 'ST1', 'ST2'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
