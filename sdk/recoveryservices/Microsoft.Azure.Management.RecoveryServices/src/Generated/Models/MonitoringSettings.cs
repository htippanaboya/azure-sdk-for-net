// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Monitoring Settings of the vault
    /// </summary>
    public partial class MonitoringSettings
    {
        /// <summary>
        /// Initializes a new instance of the MonitoringSettings class.
        /// </summary>
        public MonitoringSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonitoringSettings class.
        /// </summary>
        /// <param name="azureMonitorAlertSettings">Settings for Azure Monitor
        /// based alerts</param>
        /// <param name="classicAlertSettings">Settings for classic
        /// alerts</param>
        public MonitoringSettings(AzureMonitorAlertSettings azureMonitorAlertSettings = default(AzureMonitorAlertSettings), ClassicAlertSettings classicAlertSettings = default(ClassicAlertSettings))
        {
            AzureMonitorAlertSettings = azureMonitorAlertSettings;
            ClassicAlertSettings = classicAlertSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets settings for Azure Monitor based alerts
        /// </summary>
        [JsonProperty(PropertyName = "azureMonitorAlertSettings")]
        public AzureMonitorAlertSettings AzureMonitorAlertSettings { get; set; }

        /// <summary>
        /// Gets or sets settings for classic alerts
        /// </summary>
        [JsonProperty(PropertyName = "classicAlertSettings")]
        public ClassicAlertSettings ClassicAlertSettings { get; set; }

    }
}
