using Newtonsoft.Json;

public class PrayerTimesResponse
{
    [JsonProperty("data")]
    public PrayerTimesData? Data { get; set; }
}