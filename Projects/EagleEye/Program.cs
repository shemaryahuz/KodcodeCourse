namespace EagleEye
{
    internal class Program
    {
        static void Main()
        {
            AgentDAL agentDAL = new AgentDAL();
            Agent agent = new Agent(19, "Eagle7", "Avi", "Home", "Active", 0);
            agentDAL.AddAgent(agent);
            List<Agent> agents = agentDAL.GetAgents();
            agentDAL.ShowAgents(agents);
            Console.WriteLine("\n\n\n");
            agentDAL.UpdateLocation(17, "Car");
            agentDAL.UpdateStatus(3, "Retired");
            agents = agentDAL.GetAgents();
            agentDAL.ShowAgents(agents);
            Console.WriteLine("\n\n\n");
            agentDAL.DeleteAgent(11);
            agents = agentDAL.GetAgents();
            agentDAL.ShowAgents(agents);
        }
    }
}