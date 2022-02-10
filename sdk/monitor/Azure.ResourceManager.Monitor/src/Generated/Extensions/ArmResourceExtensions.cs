// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class to add extension methods to ArmResource. </summary>
    public static partial class ArmResourceExtensions
    {
        /// <summary> Gets a collection of DiagnosticSettings in the DiagnosticSettings. </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DiagnosticSettings and their operations over a DiagnosticSettings. </returns>
        public static DiagnosticSettingsCollection GetDiagnosticSettings(this ArmResource armResource)
        {
            return armResource.GetCachedClient((client) =>
            {
                return new DiagnosticSettingsCollection(client, armResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DiagnosticSettingsCategories in the DiagnosticSettingsCategory. </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DiagnosticSettingsCategories and their operations over a DiagnosticSettingsCategory. </returns>
        public static DiagnosticSettingsCategoryCollection GetDiagnosticSettingsCategories(this ArmResource armResource)
        {
            return armResource.GetCachedClient((client) =>
            {
                return new DiagnosticSettingsCategoryCollection(client, armResource.Id);
            }
            );
        }

        /// <summary> Gets an object representing a VmInsightsOnboardingStatus along with the instance operations that can be performed on it in the ArmResourceExtensions. </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="VmInsightsOnboardingStatus" /> object. </returns>
        public static VmInsightsOnboardingStatus GetVmInsightsOnboardingStatus(this ArmResource armResource)
        {
            return GetExtensionClient(armResource).GetVmInsightsOnboardingStatus();
        }

        /// <summary> Gets a collection of DataCollectionRuleAssociations in the DataCollectionRuleAssociation. </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataCollectionRuleAssociations and their operations over a DataCollectionRuleAssociation. </returns>
        public static DataCollectionRuleAssociationCollection GetDataCollectionRuleAssociations(this ArmResource armResource)
        {
            return armResource.GetCachedClient((client) =>
            {
                return new DataCollectionRuleAssociationCollection(client, armResource.Id);
            }
            );
        }
    }
}
