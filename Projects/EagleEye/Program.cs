namespace EagleEye
{
    internal class Program
    {
        static void Main()
        {
            AgentDAL agentDAL = new AgentDAL();
            Agent agent = new Agent(5, "Eagle7", "Avi", "Home", "Active", 0);
            agentDAL.AddAgent(agent);
            List<Agent> agents = agentDAL.GetAgents();
            agentDAL.ShowAgents(agents);
            //agentDAL.UpdateLocation(5, "Car");
            //agentDAL.UpdateStatus(5, "Retired");
            //agents = agentDAL.GetAgents();
            //agentDAL.ShowAgents(agents);
            agentDAL.DeleteAgent(5);
            agents = agentDAL.GetAgents();
            agentDAL.ShowAgents(agents);
        }
    }
}