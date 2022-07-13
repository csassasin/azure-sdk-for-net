// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class AzureMachineLearningServiceFunctionBinding : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(FunctionBindingType);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint");
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey");
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs");
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs");
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize");
                writer.WriteNumberValue(BatchSize.Value);
            }
            if (Optional.IsDefined(NumberOfParallelRequests))
            {
                writer.WritePropertyName("numberOfParallelRequests");
                writer.WriteNumberValue(NumberOfParallelRequests.Value);
            }
            if (Optional.IsDefined(InputRequestName))
            {
                writer.WritePropertyName("inputRequestName");
                writer.WriteStringValue(InputRequestName);
            }
            if (Optional.IsDefined(OutputResponseName))
            {
                writer.WritePropertyName("outputResponseName");
                writer.WriteStringValue(OutputResponseName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AzureMachineLearningServiceFunctionBinding DeserializeAzureMachineLearningServiceFunctionBinding(JsonElement element)
        {
            string type = default;
            Optional<string> endpoint = default;
            Optional<string> apiKey = default;
            Optional<IList<AzureMachineLearningServiceInputColumn>> inputs = default;
            Optional<IList<AzureMachineLearningServiceOutputColumn>> outputs = default;
            Optional<int> batchSize = default;
            Optional<int> numberOfParallelRequests = default;
            Optional<string> inputRequestName = default;
            Optional<string> outputResponseName = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("endpoint"))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiKey"))
                        {
                            apiKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inputs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AzureMachineLearningServiceInputColumn> array = new List<AzureMachineLearningServiceInputColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureMachineLearningServiceInputColumn.DeserializeAzureMachineLearningServiceInputColumn(item));
                            }
                            inputs = array;
                            continue;
                        }
                        if (property0.NameEquals("outputs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AzureMachineLearningServiceOutputColumn> array = new List<AzureMachineLearningServiceOutputColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureMachineLearningServiceOutputColumn.DeserializeAzureMachineLearningServiceOutputColumn(item));
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("batchSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            batchSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfParallelRequests"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            numberOfParallelRequests = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("inputRequestName"))
                        {
                            inputRequestName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("outputResponseName"))
                        {
                            outputResponseName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AzureMachineLearningServiceFunctionBinding(type, endpoint.Value, apiKey.Value, Optional.ToList(inputs), Optional.ToList(outputs), Optional.ToNullable(batchSize), Optional.ToNullable(numberOfParallelRequests), inputRequestName.Value, outputResponseName.Value);
        }
    }
}
