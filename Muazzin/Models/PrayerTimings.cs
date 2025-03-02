using System.Text.Json.Serialization;

public class PrayerTimings
{
    [JsonPropertyName("fajr")]
    public string? Fajr { get; set; }= string.Empty;

    [JsonPropertyName("sunrise")]
    public string? Sunrise { get; set; } = string.Empty;

    [JsonPropertyName("dhuhr")]
    public string? Dhuhr { get; set; } = string.Empty;

    [JsonPropertyName("asr")]
    public string? Asr { get; set; } = string.Empty;

    [JsonPropertyName("maghrib")]
    public string? Maghrib { get; set; } = string.Empty;

    [JsonPropertyName("isha")]
    public string? Isha { get; set; } = string.Empty;
}