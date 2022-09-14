// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class LiveOutputData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(AssetName))
            {
                writer.WritePropertyName("assetName");
                writer.WriteStringValue(AssetName);
            }
            if (Optional.IsDefined(ArchiveWindowLength))
            {
                writer.WritePropertyName("archiveWindowLength");
                writer.WriteStringValue(ArchiveWindowLength.Value, "P");
            }
            if (Optional.IsDefined(RewindWindowLength))
            {
                if (RewindWindowLength != null)
                {
                    writer.WritePropertyName("rewindWindowLength");
                    writer.WriteStringValue(RewindWindowLength.Value, "P");
                }
                else
                {
                    writer.WriteNull("rewindWindowLength");
                }
            }
            if (Optional.IsDefined(ManifestName))
            {
                writer.WritePropertyName("manifestName");
                writer.WriteStringValue(ManifestName);
            }
            if (Optional.IsDefined(HttpLiveStreaming))
            {
                writer.WritePropertyName("hls");
                writer.WriteObjectValue(HttpLiveStreaming);
            }
            if (Optional.IsDefined(OutputSnapTime))
            {
                writer.WritePropertyName("outputSnapTime");
                writer.WriteNumberValue(OutputSnapTime.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LiveOutputData DeserializeLiveOutputData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<string> assetName = default;
            Optional<TimeSpan> archiveWindowLength = default;
            Optional<TimeSpan?> rewindWindowLength = default;
            Optional<string> manifestName = default;
            Optional<Hls> hls = default;
            Optional<long> outputSnapTime = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<string> provisioningState = default;
            Optional<LiveOutputResourceState> resourceState = default;
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("assetName"))
                        {
                            assetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("archiveWindowLength"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            archiveWindowLength = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("rewindWindowLength"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                rewindWindowLength = null;
                                continue;
                            }
                            rewindWindowLength = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("manifestName"))
                        {
                            manifestName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hls = Hls.DeserializeHls(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputSnapTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            outputSnapTime = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("created"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModified"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceState = new LiveOutputResourceState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LiveOutputData(id, name, type, systemData.Value, description.Value, assetName.Value, Optional.ToNullable(archiveWindowLength), Optional.ToNullable(rewindWindowLength), manifestName.Value, hls.Value, Optional.ToNullable(outputSnapTime), Optional.ToNullable(created), Optional.ToNullable(lastModified), provisioningState.Value, Optional.ToNullable(resourceState));
        }
    }
}
