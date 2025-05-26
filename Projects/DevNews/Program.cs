
namespace DevNews
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Task 1 Fetch and display the 5 recent titles
            HttpResponseMessage postsResponse =  await FetchRecentPosts.FetchAllPosts();
            string postsStr = await FetchRecentPosts.ConvertToString(postsResponse);
            NewsPost[] postsArr = FetchRecentPosts.ConvertToNewsPosts(postsStr);
            FetchRecentPosts.ShowLastPosts(postsArr);
        }
    }
}
