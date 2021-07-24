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
    class DemandPlanService
    {   
        // 계획 번호가 없는 영업 마스터만 조회.
        public List<SalesMasterVO> GetPlanSM()
        {
            DemandPlanDAC dac = new DemandPlanDAC();
            List<SalesMasterVO> list = dac.GetPlanSM();
            dac.Dispose();

            return list;
        }

        // 수요 계획 등록 + 영업 마스터의 플랜 번호 추가
        public bool DMInsertTrans(DemandPlanVO dmVO)
        {
            DemandPlanDAC dac = new DemandPlanDAC();
            bool result = dac.DMInsertTrans(dmVO);
            dac.Dispose();

            return result;
        }

        // 수요 계획 조회
        public DataTable GetDemandPlanList(DemandPlanVO dmVO)
        {
            DemandPlanDAC dac = new DemandPlanDAC();
            return dac.GetDemandPlanList(dmVO);
        }
    }
}
