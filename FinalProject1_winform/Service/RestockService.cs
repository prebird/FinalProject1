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
    public class RestockService
    {
        public List<RestockOrderVO> GetROList()
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            return dac.GetROList();
        }

        public DataTable GetPrintData(string strCheckBarCodeID)
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            return dac.GetPrintData(strCheckBarCodeID);
        }

        public DataTable GetMRP(MRPSearchVO search)
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            return dac.GetMRP(search);
        }

        public DataTable GetROSuggest(MRPSearchVO search)
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            return dac.GetROSuggest(search);
        }
    }
}
