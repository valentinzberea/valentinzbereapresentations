using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;
using TestsActiveRecord;
using MonoRailProject.Controllers;

namespace MRProjectTest.Controllers
{
    [TestFixture]
    public class AgentControllerTestCases
    {
        [Test]
        public void Index_Should_RetrieveAllAgents_And_FillBag()
        {
            MockRepository _mocks = new MockRepository();
            IAgent _agentServices = _mocks.CreateMock<IAgent>();

            
            
            using(_mocks.Record())
            {
                Expect.
                    On(_agentServices).
                    Call(_agentServices.GetAll()).
                    Return(new Agent[] {}).
                    Repeat.Once();
            }

            AgentController controller = new AgentController(_agentServices);

            using(_mocks.Playback())
            {
                controller.Index();
            }
            
            Assert.IsNotNull(controller.PropertyBag["agents"], "Agents list should be passed to the view");

        }
    }
}
