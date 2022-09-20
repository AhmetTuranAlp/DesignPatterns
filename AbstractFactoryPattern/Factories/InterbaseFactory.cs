using AbstractFactoryPattern.Abstraction;
using AbstractFactoryPattern.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    public class InterbaseFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterbaseCommand();
        }

        public override Connection CreateConnection()
        {
            return new InterbaseConnection();
        }
    }   
}
