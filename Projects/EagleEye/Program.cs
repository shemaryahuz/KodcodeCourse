namespace EagleEye
{
    internal class Program
    {
        static void Main()
        {
            AgentDAL agentDAL = new AgentDAL();
            Agent agent = new Agent(30, "Eagle7", "Avi", "Home", "Active", 0);
            agentDAL.AddAgent(agent);
            List<Agent> agents = agentDAL.GetAgents();
            agentDAL.ShowAgents(agents);
            Console.WriteLine("\n\n\n");
            agentDAL.UpdateLocation(30, "Car");
            agentDAL.UpdateStatus(30, "Retired");
            agents = agentDAL.GetAgents();
            agentDAL.ShowAgents(agents);
            Console.WriteLine("\n\n\n");
            agentDAL.DeleteAgent(30);
            agents = agentDAL.GetAgents();
            agentDAL.ShowAgents(agents);
        }
    }
}