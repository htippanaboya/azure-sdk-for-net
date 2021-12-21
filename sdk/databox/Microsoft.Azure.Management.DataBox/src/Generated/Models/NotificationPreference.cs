// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Notification preference for a job stage.
    /// </summary>
    public partial class NotificationPreference
    {
        /// <summary>
        /// Initializes a new instance of the NotificationPreference class.
        /// </summary>
        public NotificationPreference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationPreference class.
        /// </summary>
        /// <param name="stageName">Name of the stage. Possible values include:
        /// 'DevicePrepared', 'Dispatched', 'Delivered', 'PickedUp',
        /// 'AtAzureDC', 'DataCopy', 'Created', 'ShippedToCustomer'</param>
        /// <param name="sendNotification">Notification is required or
        /// not.</param>
        public NotificationPreference(string stageName, bool sendNotification)
        {
            StageName = stageName;
            SendNotification = sendNotification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the stage. Possible values include:
        /// 'DevicePrepared', 'Dispatched', 'Delivered', 'PickedUp',
        /// 'AtAzureDC', 'DataCopy', 'Created', 'ShippedToCustomer'
        /// </summary>
        [JsonProperty(PropertyName = "stageName")]
        public string StageName { get; set; }

        /// <summary>
        /// Gets or sets notification is required or not.
        /// </summary>
        [JsonProperty(PropertyName = "sendNotification")]
        public bool SendNotification { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StageName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StageName");
            }
        }
    }
}
