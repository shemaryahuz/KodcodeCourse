namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicConnection connection = new BasicConnection();
            string query = "SELECT * FROM orders";
            connection.GetData(query);
        }
    }
}
