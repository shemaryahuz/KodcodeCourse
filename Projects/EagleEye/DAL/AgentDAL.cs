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
        private string _connectionStr;
        private MySqlConnection _connection;
        public AgentDAL(string connectionStr = "server=localhost;username=root;password=;database=eagle_eye_db")
        {
            this._connectionStr = connectionStr;
            this._connection = new MySqlConnection(this._connectionStr);
        }
        public void OpenConnection()
        {
            this._connection.Open();
        }
        public void CloseConnection()
        {
            this._connection.Close();
        }
        public void AddAgent(Agent agent)
        {
            try
            {
                string query = "INSERT INTO agents (id, codeName, realName, location, status, missionCompleted) " +
                                "VALUES (@id, @codeName, @realName, @location, @status, @missionCompleted)";

                MySqlCommand command = new MySqlCommand(query, this._connection);
                command.Parameters.AddWithValue("@id", agent.ID);
                command.Parameters.AddWithValue("@codeName", agent.CodeName);
                command.Parameters.AddWithValue("@realName", agent.RealName);
                command.Parameters.AddWithValue("@location", agent.Location);
                command.Parameters.AddWithValue("@status", agent.Status);
                command.Parameters.AddWithValue("@missionCompleted", agent.MissionCompleted);

                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL eror: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public Agent GetAgent(int agentId)
        {
            Agent agent;
            try
            {
                string query = $"SELECT * FROM agents WHERE id={agentId}";
                MySqlCommand command = new MySqlCommand(query, this._connection);
                MySqlDataReader reader = command.ExecuteReader();
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
            catch(MySqlException ex)
            {
                Console.WriteLine($"MySQL eror: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }
        public List<Agent> GetAgents()
        {
            List<Agent> agents = new List<Agent>();
            try
            {
                string query = "SELECT * FROM agents";
                MySqlCommand command = new MySqlCommand(query, this._connection);
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
            catch(MySqlException ex)
            {
                Console.WriteLine($"MySQL eror: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return agents;
        }
        public void UpdateLocation(int agentId, string location)
        {
            try
            {
                string query = $"UPDATE agents (location) VALUES (@location)";
                MySqlCommand command = new MySqlCommand(query, this._connection);
                command.Parameters.AddWithValue("@location", location);
                command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"MySQL eror: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public void UpdateStatus(int agentId, string status)
        {
            try
            {
                string query = $"UPDATE agents (status) VALUES (@status)";
                MySqlCommand command = new MySqlCommand(query, this._connection);
                command.Parameters.AddWithValue("@status", status);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL eror: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public void DeleteAgent(int agentId)
        {
            try
            {
                string query = $"DELETE FROM agents WHERE id={agentId}";
                MySqlCommand command = new MySqlCommand(query, this._connection);
                command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"MySQL eror: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
