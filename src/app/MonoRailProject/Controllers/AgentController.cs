namespace MonoRailProject.Controllers
{
    using TestsActiveRecord;

    public class AgentController:BaseController
    {
        public void Index()
        {
            PropertyBag["agents"] = Agent.FindAll();
        }
    }
}
