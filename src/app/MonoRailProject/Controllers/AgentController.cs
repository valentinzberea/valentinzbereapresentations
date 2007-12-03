using TestsActiveRecord;
namespace MonoRailProject.Controllers
{
    public class AgentController:BaseController
    {
        private readonly IAgent _Agent;
        public AgentController()
        {
            _Agent = new Agent();
        }
        public AgentController(IAgent agent)
        {
            _Agent = agent;
        }

        public void Index()
        {
            BindAllAgents();
        }

        public void Refresh()
        {
            
        }

        private void BindAllAgents()
        {
            PropertyBag["agents"] = _Agent.GetAll();
        }
    }
}
