namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicConnection connection = new BasicConnection();
            connection.GetOrdersData();
        }
    }
}
