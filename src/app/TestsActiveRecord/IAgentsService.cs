namespace TestsActiveRecord
{
    public interface IAgentsService
    {
        Agent[] GetAll();
        Agent[] GetByFilter(bool isActive);
    }
}