namespace rider_issue_1;

[System.Text.Json.Serialization.JsonConverter(typeof(SampleValueConverter))]
public record SampleValue();