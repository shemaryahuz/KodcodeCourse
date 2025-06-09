using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EagleEye
{
    internal class AgentFactory
    {
        private string[] _codeNames;
        private string[] _realNames;
        private string[] _locations;
        private string[] _statuses;
        private int[] _missionCompleted;
        public List<Agent> Agents { get; set; }
        public AgentFactory()
        {
            this._realNames = new string[] { "Avi", "Moshe", "Ben", "Jhon", "Israel" };
            this._locations = new string[] { "Home", "Car", "Plain", "Office", "Bus"};
            this._statuses = new string[] {"Active", "Injured", "Missing", "Retired", "Active" };
            this._missionCompleted = new int[] { 1, 0, 0, 1, 0};
            this.Agents = new List<Agent>();
            for (int i = 30; i < 35; i++)
            {
                Agent agent = new Agent(
                    i,
                    $"eagle{i}",
                    this._realNames[i],
                    this._locations[i],
                    this._statuses[i],
                    this._missionCompleted[i]
                    );
                this.Agents.Add(agent);
            }
        }
    }
}
