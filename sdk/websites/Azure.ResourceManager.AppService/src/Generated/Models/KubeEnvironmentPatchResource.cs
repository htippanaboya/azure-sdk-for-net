// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> ARM resource for a KubeEnvironment when patching. </summary>
    public partial class KubeEnvironmentPatchResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of KubeEnvironmentPatchResource. </summary>
        public KubeEnvironmentPatchResource()
        {
        }

        /// <summary> Initializes a new instance of KubeEnvironmentPatchResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="provisioningState"> Provisioning state of the Kubernetes Environment. </param>
        /// <param name="deploymentErrors"> Any errors that occurred during deployment or deployment validation. </param>
        /// <param name="internalLoadBalancerEnabled"> Only visible within Vnet/Subnet. </param>
        /// <param name="defaultDomain"> Default Domain Name for the cluster. </param>
        /// <param name="staticIp"> Static IP of the KubeEnvironment. </param>
        /// <param name="arcConfiguration">
        /// Cluster configuration which determines the ARC cluster
        /// components types. Eg: Choosing between BuildService kind,
        /// FrontEnd Service ArtifactsStorageType etc.
        /// </param>
        /// <param name="appLogsConfiguration">
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only &quot;log-analytics&quot; is
        /// supported
        /// </param>
        /// <param name="aksResourceID"></param>
        internal KubeEnvironmentPatchResource(ResourceIdentifier id, string name, ResourceType type, string kind, KubeEnvironmentProvisioningState? provisioningState, string deploymentErrors, bool? internalLoadBalancerEnabled, string defaultDomain, string staticIp, ArcConfiguration arcConfiguration, AppLogsConfiguration appLogsConfiguration, string aksResourceID) : base(id, name, type, kind)
        {
            ProvisioningState = provisioningState;
            DeploymentErrors = deploymentErrors;
            InternalLoadBalancerEnabled = internalLoadBalancerEnabled;
            DefaultDomain = defaultDomain;
            StaticIp = staticIp;
            ArcConfiguration = arcConfiguration;
            AppLogsConfiguration = appLogsConfiguration;
            AksResourceID = aksResourceID;
        }

        /// <summary> Provisioning state of the Kubernetes Environment. </summary>
        public KubeEnvironmentProvisioningState? ProvisioningState { get; }
        /// <summary> Any errors that occurred during deployment or deployment validation. </summary>
        public string DeploymentErrors { get; }
        /// <summary> Only visible within Vnet/Subnet. </summary>
        public bool? InternalLoadBalancerEnabled { get; set; }
        /// <summary> Default Domain Name for the cluster. </summary>
        public string DefaultDomain { get; }
        /// <summary> Static IP of the KubeEnvironment. </summary>
        public string StaticIp { get; set; }
        /// <summary>
        /// Cluster configuration which determines the ARC cluster
        /// components types. Eg: Choosing between BuildService kind,
        /// FrontEnd Service ArtifactsStorageType etc.
        /// </summary>
        public ArcConfiguration ArcConfiguration { get; set; }
        /// <summary>
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only &quot;log-analytics&quot; is
        /// supported
        /// </summary>
        public AppLogsConfiguration AppLogsConfiguration { get; set; }
        /// <summary> Gets or sets the aks resource id. </summary>
        public string AksResourceID { get; set; }
    }
}
