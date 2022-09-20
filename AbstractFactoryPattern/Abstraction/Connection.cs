using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Abstraction
{
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnect();
        public abstract string State { get; }
    }
}
