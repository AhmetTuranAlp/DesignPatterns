using AbstractFactoryPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteProduct
{
    public class SqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("Sql Bağlantısı açılacak...");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("Sql Bağlantısı kapatılacak...");
            return true;
        }
    }
}
