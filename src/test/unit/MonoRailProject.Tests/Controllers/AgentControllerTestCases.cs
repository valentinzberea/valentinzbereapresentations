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
        public void Index_Should_ReturnAgentsList()
        {
            MockRepository _mocks = new MockRepository();
            IAgentsService _serviceMock = _mocks.CreateMock<IAgentsService>();

            Agent[] testAgents = new Agent[] {new Agent{Id =1,Nume ="Test"}};
            using(_mocks.Record())
            {
                using(_mocks.Ordered())
                {
                
                }
                Expect.
                    On(_serviceMock).
                    Call(_serviceMock.GetAll()).
                    Return(testAgents).
                    Repeat.Once();

                Expect.
                    On(_serviceMock).
                    Call(_serviceMock.GetAll()).
                    Return(null).
                    Repeat.Once();
        }

            AgentController controller;
            using(_mocks.Playback())
            {
            controller = new AgentController(_serviceMock);
            controller.Index();
        }

            Assert.AreEqual(testAgents, controller.PropertyBag["agents"]);
        }
    }
}
