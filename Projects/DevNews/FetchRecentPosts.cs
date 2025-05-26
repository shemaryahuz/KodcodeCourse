using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DevNews
{
    internal static class FetchRecentPosts
    {
        public static async Task<HttpResponseMessage> FetchAllPosts()
        {
            HttpClient client = new HttpClient();
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";
            HttpResponseMessage postsResponse = await client.GetAsync(apiUrl);
            return postsResponse;
        }
        public static async Task<string> ConvertToString(HttpResponseMessage postsResponse)
        {
            string postsStr = await postsResponse.Content.ReadAsStringAsync();
            return postsStr;
        }
        public static NewsPost[] ConvertToNewsPosts(string postsStr)
        {
            NewsPost[]? postsArr = JsonSerializer.Deserialize<NewsPost[]>(postsStr);
            return postsArr;
        }
        public static void ShowLastPosts(NewsPost[] postsArr)
        {
            Console.WriteLine("Last 5 Posts:\n\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(
                    $"Title: {postsArr[i].title}\n\n" +
                    $"Body: {postsArr[i].body}\n\n");
            }
        }
    }
}
