using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public class CommonService
    {
        public List<MenuVO> GetAllMenu()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetAllMenu();
        }

        public List<MenuVO> GetAllMenuMgt()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetAllMenu();
        }

        public List<CommonCodeVO> GetCommonCode(string common_type)
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCommonCode(common_type);
        }

        // planid 콤보바인딩용
        public List<DemandPlanVO> GetCommboDemandPlan()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCommboDemandPlan();
        }

        public List<ItemVO> GetCommboProductName()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCommboProductName();
        }
    }
}
