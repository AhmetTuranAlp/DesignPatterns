using AbstractFactoryPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteProduct
{
    public class InterbaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("Interbase Sorgusu Çalıştırılır...");
        }
    }
}
