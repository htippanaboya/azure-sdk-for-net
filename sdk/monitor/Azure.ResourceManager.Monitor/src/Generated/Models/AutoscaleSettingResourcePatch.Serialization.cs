// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AutoscaleSettingResourcePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Profiles))
            {
                writer.WritePropertyName("profiles");
                writer.WriteStartArray();
                foreach (var item in Profiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Notifications))
            {
                if (Notifications != null)
                {
                    writer.WritePropertyName("notifications");
                    writer.WriteStartArray();
                    foreach (var item in Notifications)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("notifications");
                }
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(TargetResourceUri))
            {
                writer.WritePropertyName("targetResourceUri");
                writer.WriteStringValue(TargetResourceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(TargetResourceLocation))
            {
                writer.WritePropertyName("targetResourceLocation");
                writer.WriteStringValue(TargetResourceLocation);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
