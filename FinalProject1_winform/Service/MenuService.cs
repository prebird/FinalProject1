using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_DAC;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public class MenuService
    {
        public bool insertBigMenu(MenuVO menu)
        {
            MenuDAC dac = new MenuDAC();
            return dac.insertBigMenu(menu);
        }

        public bool insertSmallMenu(MenuVO menu)
        {
            MenuDAC dac = new MenuDAC();
            return dac.insertSmallMenu(menu);
        }
    }
}
