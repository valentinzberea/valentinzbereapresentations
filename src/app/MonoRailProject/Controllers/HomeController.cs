namespace MonoRailProject.Controllers
{
	using System;

	public class HomeController : BaseController
	{
		public void Index()
		{
			PropertyBag["AccessDate"] = DateTime.Now;
		}
	}
}
