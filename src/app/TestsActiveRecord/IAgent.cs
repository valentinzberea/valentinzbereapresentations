using Castle.ActiveRecord;

namespace TestsActiveRecord
{
    public interface IAgent
    {
        [PrimaryKey]
        int Id { get; set; }

        [Property]
        string Nume { get; set; }

        [Property]
        string Email { get; set; }

        [Property]
        bool Activ { get; set; }

        [Property]
        int OrasActivitate { get; set; }

        Agent[] GetAll();
        void CreateAndFlush();
        void UpdateAndFlush();
        void DeleteAndFlush();

    }
}