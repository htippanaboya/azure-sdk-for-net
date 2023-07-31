// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.Public.ResourceManager.Resources.Models
{
    public partial class ZoneMapping : IUtf8JsonSerializable, IModelJsonSerializable<ZoneMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ZoneMapping>)this).Serialize(writer, new ModelSerializerOptions(ModelSerializerFormat.Wire));

        internal static ZoneMapping DeserializeZoneMapping(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultServiceOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyList<string>> zones = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
            }
            return new ZoneMapping(Optional.ToNullable(location), Optional.ToList(zones));
        }

        void IModelJsonSerializable<ZoneMapping>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value.DisplayName);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        private struct ZoneMappingProperties
        {
            public Optional<AzureLocation> Location { get; set; }
            public Optional<IReadOnlyList<string>> Zones { get; set; }
        }

        ZoneMapping IModelJsonSerializable<ZoneMapping>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (!reader.TryDeserialize<ZoneMappingProperties>(options, SetProperty, out var properties))
                return null;

            return new ZoneMapping(Optional.ToNullable(properties.Location), Optional.ToList(properties.Zones));
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref ZoneMappingProperties properties, ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (propertyName.SequenceEqual("location"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Location = new AzureLocation(reader.GetString());
                return;
            }
            if (propertyName.SequenceEqual("zones"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Zones = reader.GetList<string>(options);
                return;
            }
            reader.Skip();
        }

        ZoneMapping IModelSerializable<ZoneMapping>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeZoneMapping(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ZoneMapping>.Serialize(ModelSerializerOptions options)
        {
            return ModelSerializerHelper.SerializeToBinaryData((writer) => { Serialize(writer, options); });
        }
    }
}
