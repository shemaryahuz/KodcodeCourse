using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

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
        public Agent GetAgent(int agentId)
        {
            this._conn.Open();
            Agent agent;
            try
            {
                string query = $"SELECT * FROM agents WHERE id={agentId}";
                MySqlCommand command = new MySqlCommand(query, this._conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    agent = new Agent(
                        reader.GetInt32("id"),
                        reader.GetString("codeName"),
                        reader.GetString("realName"),
                        reader.GetString("location"),
                        reader.GetString("status"),
                        reader.GetInt32("missionCompleted")
                        );
                    return agent;
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
            return null;
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
        public void ShowAgent(Agent agent)
        {
            Console.WriteLine(
                   $"ID: {agent.ID}. " +
                   $"CodeName: {agent.CodeName}. " +
                   $"RealName: {agent.RealName}. " +
                   $"Location: {agent.Location}. " +
                   $"Status: {agent.Status}. " +
                   $"MissionCompleted: {(agent.MissionCompleted == 0 ? "Not Completed" : "Completed")}");
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
            this._conn.Open();
            string query = $"UPDATE agents (location) VALUES (@location)";
            MySqlCommand command = new MySqlCommand(query, this._conn);
            command.Parameters.AddWithValue("@location", location);
            command.ExecuteNonQuery();
            this._conn.Close();
        }
        public void UpdateStatus(int agentId, string status)
        {
            this._conn.Open();
            string query = $"UPDATE agents (status) VALUES (@status)";
            MySqlCommand command = new MySqlCommand(query, this._conn);
            command.Parameters.AddWithValue("@status", status);
            command.ExecuteNonQuery();
            this._conn.Close();
        }
        public void DeleteAgent(int agentId)
        {
            this._conn.Open();
            string query = $"DELETE FROM agents WHERE id={agentId}";
            MySqlCommand command = new MySqlCommand(query, this._conn);
            command.ExecuteNonQuery();
            this._conn.Close();
        }
    }
}
