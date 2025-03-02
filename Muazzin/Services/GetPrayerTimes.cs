using Newtonsoft.Json;

namespace PrayerTimes.Services;

public class GetPrayerTimes
{
    private static readonly HttpClient client = new();

    public async Task<PrayerTimings> GetPrayerTimesAsync(string city, string country, string date)
    {
        string url = $"https://api.aladhan.com/v1/timingsByCity/{date}?city={city}&country={country}&method=4&school=1";
        var response = await client.GetStringAsync(url);

        var jsonResponse = JsonConvert.DeserializeObject<PrayerTimesResponse>(response);

        if(jsonResponse != null)
        {
            return new PrayerTimings
            {
                Fajr = jsonResponse.Data!.Timings!.Fajr,
                Sunrise = jsonResponse.Data.Timings.Sunrise,
                Dhuhr = jsonResponse.Data.Timings.Dhuhr,
                Asr = jsonResponse.Data.Timings.Asr,
                Maghrib = jsonResponse.Data.Timings.Maghrib,
                Isha = jsonResponse.Data.Timings.Isha,
            };
        }
        return null!;
    }
}