using AbstractFactoryPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
