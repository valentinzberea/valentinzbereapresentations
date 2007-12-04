using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestsActiveRecord
{
    public class AgentsService : IAgentsService
    {
        public Agent[] GetAll()
        {
            return Agent.FindAll();
        }

        public Agent[] GetByFilter(bool isActive)
        {
            return Agent.FindAllByProperty("Active", isActive);
        }
    }
}
