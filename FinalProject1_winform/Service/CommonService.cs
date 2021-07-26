using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProject1_VO;
using FinalProject1_DAC;
using System.Data;

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

        public List<RestockOrderVO> GetCommboROID()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCommboROID();
        }

        public List<ItemVO> GetCommboProductName()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCommboProductName();
        }

        public DataTable GetMenuList()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetMenuList();
        }

        public List<Item_Combo_VO> GetCommboItemName()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCommboItemName();
        }

        public List<CompanyVO> GetCommboCompanyName()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCommboCompanyName();
        }

        public List<FactoryVO> GetCommboWHid()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCommboWHid();
        }
    }
}
