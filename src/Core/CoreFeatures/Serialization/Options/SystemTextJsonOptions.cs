using Core.CoreFeatures.Interfaces.Serialization.Options;

using System.Text.Json;

namespace Core.CoreFeatures.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}