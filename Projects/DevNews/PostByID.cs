using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DevNews
{
    internal static class PostByID
    {
        public static string GetID()
        {
            Console.WriteLine("To read a specific Post, Please enter the Post's ID (1 - 100)");
            string id = Console.ReadLine();
            return id;
        }
        public static bool ValidateID(string id)
        {
            int intId;
            if (!int.TryParse(id, out intId))
            {
                return false;
            }
            else if (intId < 1 || intId > 100)
            {
                return false;
            }
            return true;
        }
        public static async Task<HttpResponseMessage> FetchPostByID(HttpClient client, string id)
        {
            string postUrl = $"https://jsonplaceholder.typicode.com/posts?id={id}";
            HttpResponseMessage postResponse = await client.GetAsync(postUrl);
            return postResponse;
        }
        public static NewsPost ConvertToNewsPost(string postStr)
        {
            NewsPost? post = JsonSerializer.Deserialize<NewsPost>(postStr);
            return post;
        }
        public static void ShowPost(NewsPost post)
        {
            Console.WriteLine(
                $"Post ID: {post.id}.\n" +
                $"Title: {post.title}.\n" +
                $"Body: {post.body}");
        }
    }
}
