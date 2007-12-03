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
    public class Agent : ActiveRecordBase<Agent>
    {
        private int id;
        private String name;

        [PrimaryKey]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Property]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string _Email;
        [Property]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private bool _Active;
        [Property]
        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
    }
}
