using AbstractFactoryPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteProduct
{
    public class SqlCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("Sql Sorgusu Çalıştırılır...");
        }
    }
}
