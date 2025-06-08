using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye
{
    internal class AgentDAL
    {
        private string _connStr;
        private MySqlConnection _conn;
        private bool _connIsOpen;
        public AgentDAL()
        {
            this._connStr = "server=localhost;username=root;password=;database=eagle_eye_db";
            this._conn = new MySqlConnection(this._connStr);
        }
        public void AddAgent(Agent agent)
        {
            try
            {
                this._conn.Open();
                string query = "INSERT INTO agents (id, codeName, realName, location, status, missionCompleted) " +
                                "VALUES (@id, @codeName, @realName, @location, @status, @missionCompleted)";

                MySqlCommand command = new MySqlCommand(query, this._conn);
                command.Parameters.AddWithValue("@id", agent.ID);
                command.Parameters.AddWithValue("@codeName", agent.CodeName);
                command.Parameters.AddWithValue("@realName", agent.RealName);
                command.Parameters.AddWithValue("@location", agent.Location);
                command.Parameters.AddWithValue("@status", agent.Status);
                command.Parameters.AddWithValue("@missionCompleted", agent.MissionCompleted);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                this._conn.Close();
            }
        }
        public List<Agent> GetAgents()
        {
            this._conn.Open();
            List<Agent> agents = new List<Agent>();
            try
            {
                string query = "SELECT * FROM agents";
                MySqlCommand command = new MySqlCommand(query, this._conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Agent agent = new Agent(
                        reader.GetInt32("id"),
                        reader.GetString("codeName"),
                        reader.GetString("realName"),
                        reader.GetString("location"),
                        reader.GetString("status"),
                        reader.GetInt32("missionCompleted")
                        );
                    agents.Add(agent);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                this._conn.Close();
            }
            return agents;
        }
        public void ShowAgents(List<Agent> agents)
        {
            foreach (Agent agent in agents)
            {
                Console.WriteLine(
                    $"ID: {agent.ID}. " +
                    $"CodeName: {agent.CodeName}. " +
                    $"RealName: {agent.RealName}. " +
                    $"Location: {agent.Location}. " +
                    $"Status: {agent.Status}. " +
                    $"MissionCompleted: {(agent.MissionCompleted == 0 ? "Not Completed" : "Completed")}");
            }
        }
        public void UpdateLocation(int agentId, string location)
        {
            string query = $"SELECT * FROM agents WHERE id LIKE '{agentId}'";
            MySqlCommand command = new MySqlCommand(query, this._conn);
            
        }
        public void UpdateStatus(int agentId, string status)
        {
            string query = $"SELECT * FROM agents WHERE id LIKE '{agentId}'";
            MySqlCommand command = new MySqlCommand(query, this._conn);

        }
        public void DeleteAgent(int agentId)
        {
            this._conn.Open();
            string query = $"SELECT * FROM agents WHERE id LIKE '{agentId}'";
            MySqlCommand command = new MySqlCommand(query, this._conn);
            command.ExecuteNonQuery();
            this._conn.Close();
        }
        private void ShowMenu()
        {
            Console.WriteLine(
                "--Eagle Eye Database--\n" +
                "Options:\n" +
                "1. Add agent.\n" +
                "2. Show all agents.\n" +
                "3. Update agent location.\n" +
                "4. Update agent status.\n" +
                "5. Delete agent.\n" +
                "6. Exit.");
        }
        private string GetSelection()
        {
            Console.WriteLine("Enter your selection:");
            return Console.ReadLine();
        }
        private bool Validate(string selection)
        {
            string[] validated = { "1", "2", "3", "4", "5" };
            return validated.Contains(selection);
        }
        private void ExecuteSelection(string selection)
        {
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Not possible yet.");
                    break;
                case "2":
                    this.ShowAgents(this.GetAgents());
                    break;
                case "3":
                    Console.WriteLine("Not possible yet.");
                    break;
                case "4":
                    Console.WriteLine("Not possible yet.");
                    break;
                case "5":
                    Console.WriteLine("Not possible yet.");
                    break;
            }
        }
        public void ManipulateData()
        {
            try
            {
                this._conn.Open();
                bool toExit = false;
                string exit = "6";
                while (!toExit)
                {
                    this.ShowMenu();
                    string selection = this.GetSelection();
                    if (selection == exit)
                    {
                        toExit = true;
                        continue;
                    }
                    bool validated = this.Validate(selection);
                    if (!validated)
                    {
                        Console.WriteLine("Invalid input.");
                        continue;
                    }
                    this.ExecuteSelection(selection);
                }   
            }
            catch (Exception e)
            {
                Console.WriteLine($"Eror: {e.Message}");
            }
            finally
            {
                this._conn.Close();
            }

        }
    }
}
