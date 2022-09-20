using AbstractFactoryPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteProduct
{
    public class InterbaseConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("Interbase Bağlantısı açılacak...");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("Interbase Bağlantısı kapatılacak...");
            return true;
        }
    }
}
