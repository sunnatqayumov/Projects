using System.Text.Json.Serialization;

public class PrayerTimesData
{
    public PrayerTimings? Timings { get; set; } = new PrayerTimings();
    public MetaDate? Meta { get; set; } = new MetaDate();
}