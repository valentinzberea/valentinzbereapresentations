using TestsActiveRecord;
namespace MonoRailProject.Controllers
{
    public class AgentController:BaseController
    {
        private IAgentsService _service;
        public AgentController(IAgentsService service)
        {
            _service = service;
        }
        public AgentController()
        {
            _service = new AgentsService();
        }

        public void Index()
        {
            PropertyBag["filterValues"] = new string[] {"(All)","Active","Inactive"};

            BindAgents();
        }

        private void BindAgents()
        {
            PropertyBag["agents"] = _service.GetAll();
        }

        public void Filter(string filterValue)
        {
            RedirectToAction("index");
        }
    }
}
