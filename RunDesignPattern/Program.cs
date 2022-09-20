using AbstractFactoryPattern;
using AbstractFactoryPattern.Factories;
using FactoryMethodPattern;
using System;

namespace RunDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FactoryMethodPattern
            //Creator creator = new Creator();
            //Screen screenWindows = creator.ScreenFactory(ScreenModeEnum.Windows);
            //Screen screenWeb = creator.ScreenFactory(ScreenModeEnum.Web);
            //Screen screenMobile = creator.ScreenFactory(ScreenModeEnum.Mobile);

            //screenWindows.Draw();
            //screenWeb.Draw();
            //screenMobile.Draw();
            //Console.ReadLine(); 
            #endregion

            #region AbstractFactoryPattern
            Factory factory = new Factory(new InterbaseFactory());
            factory.Start();

            Console.WriteLine("");

            Factory factory2 = new Factory(new SqlFactory());
            factory2.Start();
            #endregion
        }
    }
}
