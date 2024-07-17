﻿using Core.CoreFeatures.Interfaces.Serialization.Serializers;
using Core.CoreFeatures.Serialization.Options;

using Microsoft.Extensions.Options;

using System.Text.Json;

namespace Core.CoreFeatures.Serialization.Serializers
{
    public class SystemTextJsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerOptions _options;

        public SystemTextJsonSerializer(IOptions<SystemTextJsonOptions> options)
        {
            _options = options.Value.JsonSerializerOptions;
        }

        public T Deserialize<T>(string data)
            => JsonSerializer.Deserialize<T>(data, _options);

        public string Serialize<T>(T data)
            => JsonSerializer.Serialize(data, _options);
    }
}