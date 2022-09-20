using FactoryMethodPattern.ScreenTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Creator
    {
        /// <summary>
        /// FactoryMethod
        /// </summary>
        /// <param name="screenMode">Ekran Tipi</param>
        /// <returns></returns>
        public Screen ScreenFactory(ScreenModeEnum screenMode)
        {
            Screen screen = null;
            switch (screenMode)
            {
                case ScreenModeEnum.Windows:
                    screen = new WinScreen(); break;
                case ScreenModeEnum.Web:
                    screen = new WebScreen(); break;
                case ScreenModeEnum.Mobile:
                    screen = new MobileScreen(); break;
                default:
                    break;
            }
            return screen;
        }
    }
}
