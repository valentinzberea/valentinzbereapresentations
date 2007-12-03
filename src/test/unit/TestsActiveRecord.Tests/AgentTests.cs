using NUnit.Framework;

namespace TestsActiveRecord.Tests
{
    [TestFixture]
    public class AgentTests:AbstractModelTestCase
    {
        [Test]
        public void AgentsTests()
        {
            Agent[] allAgents = Agent.FindAll();
            Assert.IsTrue(allAgents.Length == 0);
        }
    }
}
