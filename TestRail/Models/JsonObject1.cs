using System.Text.Json.Serialization;

namespace TestRail.Models
{
    public class JsonObject1
    {
        [JsonPropertyName("name")] public string FirstPersoneName { get; set; }
        [JsonPropertyName("last name")] public string SecondName { get; set; }
        [JsonPropertyName("id")] public int Identifier { get; set; }
        [JsonPropertyName("age")] public int Age { get; set; }
    }
}
