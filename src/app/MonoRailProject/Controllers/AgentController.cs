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

        const string ALL = "(All)";
        const string ACTIVE ="Active";
        const string INACTIVE = "Inactive";

        public void Index()
        {
            PropertyBag["filterValues"] = new string[] {ALL,ACTIVE,INACTIVE};

            string filterValue = Params["filter"];

            switch (filterValue)
            {
                case ALL:
                    PropertyBag["agents"] = _service.GetAll();
                    break;
                case ACTIVE:
                    PropertyBag["agents"] = _service.GetByFilter(true);
                    break;
                case INACTIVE:
                    PropertyBag["agents"] = _service.GetByFilter(false);
                    break;
            }
            
        }


        public void Filter(string filterValue)
        {
            RedirectToAction("index",string.Format("filter={0}",filterValue));
        }
    }
}
