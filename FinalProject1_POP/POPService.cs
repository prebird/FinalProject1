using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_DAC;
using FinalProject1_VO;

namespace FinalProject1_POP
{
    public class POPService
    {
        public List<POPVO> GetUserInfo(string userId)
        {
            POPDAC dac = new POPDAC();
            List<POPVO> list = dac.GetUserInfo(userId);
            dac.Dispose();

            return list;
        }

        public List<POPUserVO> GetUserWork(string userId)
        {
            POPDAC dac = new POPDAC();
            List<POPUserVO> list = dac.GetUserWork(userId);
            dac.Dispose();

            return list;
        }

        public List<POPProcessVO> GetProcessInfo()
        {
            POPDAC dac = new POPDAC();
            List<POPProcessVO> list = dac.GetProcessInfo();
            dac.Dispose();

            return list;
        }

        public List<POPItemVO> GetItemInfo()
        {
            POPDAC dac = new POPDAC();
            List<POPItemVO> list = dac.GetItemInfo();
            dac.Dispose();

            return list;
        }

    }
}
