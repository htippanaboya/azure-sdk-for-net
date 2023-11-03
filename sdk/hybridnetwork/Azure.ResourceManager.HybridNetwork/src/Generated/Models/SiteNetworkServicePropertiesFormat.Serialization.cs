// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class SiteNetworkServicePropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            if (Optional.IsDefined(SiteReference))
            {
                writer.WritePropertyName("siteReference"u8);
                JsonSerializer.Serialize(writer, SiteReference);
            }
            if (Optional.IsDefined(NetworkServiceDesignVersionResourceReference))
            {
                writer.WritePropertyName("networkServiceDesignVersionResourceReference"u8);
                writer.WriteObjectValue(NetworkServiceDesignVersionResourceReference);
            }
            if (Optional.IsCollectionDefined(DesiredStateConfigurationGroupValueReferences))
            {
                writer.WritePropertyName("desiredStateConfigurationGroupValueReferences"u8);
                writer.WriteStartObject();
                foreach (var item in DesiredStateConfigurationGroupValueReferences)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static SiteNetworkServicePropertiesFormat DeserializeSiteNetworkServicePropertiesFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<ManagedResourceGroupConfiguration> managedResourceGroupConfiguration = default;
            Optional<WritableSubResource> siteReference = default;
            Optional<string> publisherName = default;
            Optional<PublisherScope> publisherScope = default;
            Optional<string> networkServiceDesignGroupName = default;
            Optional<string> networkServiceDesignVersionName = default;
            Optional<string> networkServiceDesignVersionOfferingLocation = default;
            Optional<DeploymentResourceIdReference> networkServiceDesignVersionResourceReference = default;
            Optional<IDictionary<string, WritableSubResource>> desiredStateConfigurationGroupValueReferences = default;
            Optional<string> lastStateNetworkServiceDesignVersionName = default;
            Optional<IReadOnlyDictionary<string, WritableSubResource>> lastStateConfigurationGroupValueReferences = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedResourceGroupConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedResourceGroupConfiguration = ManagedResourceGroupConfiguration.DeserializeManagedResourceGroupConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("siteReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    siteReference = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherScope = new PublisherScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkServiceDesignGroupName"u8))
                {
                    networkServiceDesignGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkServiceDesignVersionName"u8))
                {
                    networkServiceDesignVersionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkServiceDesignVersionOfferingLocation"u8))
                {
                    networkServiceDesignVersionOfferingLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkServiceDesignVersionResourceReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkServiceDesignVersionResourceReference = DeploymentResourceIdReference.DeserializeDeploymentResourceIdReference(property.Value);
                    continue;
                }
                if (property.NameEquals("desiredStateConfigurationGroupValueReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, WritableSubResource> dictionary = new Dictionary<string, WritableSubResource>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText()));
                    }
                    desiredStateConfigurationGroupValueReferences = dictionary;
                    continue;
                }
                if (property.NameEquals("lastStateNetworkServiceDesignVersionName"u8))
                {
                    lastStateNetworkServiceDesignVersionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastStateConfigurationGroupValueReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, WritableSubResource> dictionary = new Dictionary<string, WritableSubResource>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText()));
                    }
                    lastStateConfigurationGroupValueReferences = dictionary;
                    continue;
                }
            }
            return new SiteNetworkServicePropertiesFormat(Optional.ToNullable(provisioningState), managedResourceGroupConfiguration.Value, siteReference, publisherName.Value, Optional.ToNullable(publisherScope), networkServiceDesignGroupName.Value, networkServiceDesignVersionName.Value, networkServiceDesignVersionOfferingLocation.Value, networkServiceDesignVersionResourceReference.Value, Optional.ToDictionary(desiredStateConfigurationGroupValueReferences), lastStateNetworkServiceDesignVersionName.Value, Optional.ToDictionary(lastStateConfigurationGroupValueReferences));
        }
    }
}
