using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye
{
    internal class Agent
    {
        public int ID { get; set; }
        public string CodeName { get; set; }
        public string RealName { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public int MissionCompleted { get; set; }
        public Agent(int id, string codeName, string realName, string location, string status, int missionCompleted)
        {
            this.ID = id;
            this.CodeName = codeName;
            this.RealName = realName;
            this.Location = location;
            this.Status = status;
            this.MissionCompleted = missionCompleted;
        }
    }
}
