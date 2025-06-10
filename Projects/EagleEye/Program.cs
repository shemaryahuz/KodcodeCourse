namespace EagleEye
{
    internal class Program
    {
        static void Main()
        {
            // Intialize access to the database 
            AgentDAL agentDal = AgentDAL.GetDAL();
            // Open the object of MySqlConnection
            agentDal.OpenConnection();
            // Intialize Menu Manager
            MenuManager menuManager = MenuManager.GetMenuManager();
            // Create Agent
            Agent agent = new Agent(11, "eagle11", "David", "Train", "Active", 0);
            // Send Agent to Database
            agentDal.AddAgent(agent);
            // Get Agent from Database
            Agent returnedAgent = agentDal.GetAgent(10);
            Console.WriteLine(returnedAgent.Location);
            // Show returned agent
            //menuManager.ShowAgent(returnedAgent);
            // Close the object of MySqlConnection
            agentDal.CloseConnection();
        }
    }
}