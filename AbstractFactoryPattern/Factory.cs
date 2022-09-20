using AbstractFactoryPattern.Abstraction;
using AbstractFactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Factory
    {
        private DatabaseFactory _databaseFactory;
        private Connection _connection;
        private Command _command;
        public Factory(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = databaseFactory.CreateConnection();
            _command = databaseFactory.CreateCommand();
        }

        public void Start()
        {
            _connection.Connect();
            if (_connection.State == "Open")
                _command.Execute("Select query...");
        }
    }
}
