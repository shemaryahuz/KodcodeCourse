
namespace DevNews
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //// Task 1: Fetch and display the 5 recent titles
            HttpClient client = new HttpClient();
            //HttpResponseMessage postsResponse =  await FetchRecentPosts.FetchAllPosts(client);
            //string postsStr = await FetchRecentPosts.ConvertToString(postsResponse);
            //NewsPost[] postsArr = FetchRecentPosts.ConvertToNewsPosts(postsStr);
            //FetchRecentPosts.ShowLastPosts(postsArr);



            // Task 2: View full article by ID
            string id = PostByID.GetID();
            bool validated = PostByID.ValidateID(id);
            while (!validated)
            {
                Console.WriteLine("Invalid Input!");
                id = PostByID.GetID();
                validated = PostByID.ValidateID(id);
            }
            HttpResponseMessage postResponse = await PostByID.FetchPostByID(client, id);
            string postStr = await FetchRecentPosts.ConvertToString(postResponse);
            NewsPost post = PostByID.ConvertToNewsPost(postStr);
            PostByID.ShowPost(post);
        }
    }
}
