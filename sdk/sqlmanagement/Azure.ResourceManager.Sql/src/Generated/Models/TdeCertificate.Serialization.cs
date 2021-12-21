// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class TdeCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateBlob))
            {
                writer.WritePropertyName("privateBlob");
                writer.WriteStringValue(PrivateBlob);
            }
            if (Optional.IsDefined(CertPassword))
            {
                writer.WritePropertyName("certPassword");
                writer.WriteStringValue(CertPassword);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static TdeCertificate DeserializeTdeCertificate(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> privateBlob = default;
            Optional<string> certPassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("privateBlob"))
                        {
                            privateBlob = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certPassword"))
                        {
                            certPassword = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new TdeCertificate(id, name, type, privateBlob.Value, certPassword.Value);
        }
    }
}
