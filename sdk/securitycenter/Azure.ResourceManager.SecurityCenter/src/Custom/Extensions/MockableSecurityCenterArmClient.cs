// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableSecurityCenterArmClient : ArmResource
    {
        /// <summary>
        /// Gets an object representing a <see cref="SubscriptionGovernanceRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionGovernanceRuleResource" /> object. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This method is obsolete and will be removed in a future release. Please use GetGovernanceRuleResource.", false)]
        public virtual SubscriptionGovernanceRuleResource GetSubscriptionGovernanceRuleResource(ResourceIdentifier id)
        {
            SubscriptionGovernanceRuleResource.ValidateResourceId(id);
            return new SubscriptionGovernanceRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityConnectorGovernanceRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityConnectorGovernanceRuleResource.CreateResourceIdentifier" /> to create a <see cref="SecurityConnectorGovernanceRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SecurityConnectorGovernanceRuleResource" /> object. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This method is obsolete and will be removed in a future release.", false)]
        public virtual SecurityConnectorGovernanceRuleResource GetSecurityConnectorGovernanceRuleResource(ResourceIdentifier id)
        {
            SecurityConnectorGovernanceRuleResource.ValidateResourceId(id);
            return new SecurityConnectorGovernanceRuleResource(Client, id);
        }
    }
}
