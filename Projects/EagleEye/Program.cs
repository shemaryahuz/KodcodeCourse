namespace EagleEye
{
    internal class Program
    {
        static void Main()
        {
            // Intialize access to the database 
            AgentDAL agentDal = new AgentDAL();
            // Open the object of MySqlConnection
            agentDal.OpenConnection();
            // Close the object of MySqlConnection
        }
    }
}