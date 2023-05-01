using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace pa5{
public class WorkoutGenerator
{
    private const string YoutubeApiBaseUrl = "https://www.googleapis.com/youtube/v3/search";
    private const string YoutubeApiKey = "AIzaSyDfmE1MUrXJMGJhZd8XCnlIzs9jJnHEq3A";

    public List<string> GenerateWorkoutPlan()
    {
        // Define the workout plan
        var workoutPlan = new List<string>
        {
            "Push-ups",
            "Squats",
            "Lunges",
            "Bench press",
            "Deadlifts",
            "Bicep curls",
            "Tricep extensions",
            "Shoulder press",
            "Plank",
            "Sit-ups"
        };

        // Shuffle the workout plan to make it random
        ShuffleList(workoutPlan);

        // Get the YouTube video IDs for each exercise
        var videoIds = GetVideoIdsForExercises(workoutPlan);

        // Generate the list of YouTube video URLs
        var videoUrls = GenerateVideoUrls(videoIds);

        // Combine the workout plan and video URLs into a single list
        var output = new List<string>();
        for (int i = 0; i < workoutPlan.Count; i++)
        {
            output.Add($"{workoutPlan[i]}: {videoUrls[i]}");
        }

        return output;
    }

    private void ShuffleList<T>(List<T> list)
    {
        var random = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    private List<string> GetVideoIdsForExercises(List<string> exercises)
    {
        var videoIds = new List<string>();

        using (var client = new HttpClient())
        {
            foreach (var exercise in exercises)
            {
                var query = $"{exercise} workout";
                var url = $"{YoutubeApiBaseUrl}?part=id&maxResults=1&q={query}&type=video&key={YoutubeApiKey}";

                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<dynamic>(json);
                    videoIds.Add(result.items[0].id.videoId.ToString());
                }
                else
                {
                    videoIds.Add("");
                }
            }
        }

        return videoIds;
    }

    private List<string> GenerateVideoUrls(List<string> videoIds)
    {
        var videoUrls = new List<string>();

        foreach (var videoId in videoIds)
        {
            var videoUrl = $"https://www.youtube.com/watch?v={videoId}";
            videoUrls.Add(videoUrl);
        }

        return videoUrls;
    }
}
}
