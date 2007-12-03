namespace TestsActiveRecord
{
    using System;
    using Castle.ActiveRecord;
    using NHibernate.Expression;

    // This is file is provided just as a starting point 
    // especially if you are new to ActiveRecord
    //
    // Feel free to delete it right away.

    [ActiveRecord("Agent")]
    public class Agent : ActiveRecordBase<Agent>, IAgent
    {
        [PrimaryKey] public int Id { get; set; }

        [Property] public string Nume { get; set; }
        [Property] public string Email { get; set; }
        [Property] public bool Activ { get; set; }

        
        [Property] public int OrasActivitate{ get; set;}

        public Agent[] GetAll()
        {
            return Agent.FindAll();
        }
    }
}
