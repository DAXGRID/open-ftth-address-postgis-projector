using System.Text.Json.Serialization;

namespace OpenFTTH.AddressPostgisProjector;

internal sealed record Setting
{
    [JsonPropertyName("eventStoreConnectionString")]
    public string EventStoreConnectionString { get; init; }

    [JsonPropertyName("postgisConnectionString")]
    public string PostgisConnectionString { get; init; }

    [JsonConstructor]
    public Setting(string eventStoreConnectionString, string postgisConnectionString)
    {
        if (String.IsNullOrWhiteSpace(eventStoreConnectionString))
        {
            throw new ArgumentException(
                "Cannot be null or whitespace.", nameof(eventStoreConnectionString));
        }

        if (String.IsNullOrWhiteSpace(postgisConnectionString))
        {
            throw new ArgumentException(
                "Cannot be null or whitespace.", nameof(eventStoreConnectionString));
        }

        EventStoreConnectionString = eventStoreConnectionString;
        PostgisConnectionString = postgisConnectionString;
    }
}
