﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    class SalesMasterService
    {
        // 등록
        public bool InsertSalesMaster(SalesMasterVO smVO)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            bool result = dac.InsertSalesMaster(smVO);
            dac.Dispose();

            return result;
        }

        // 전체 조회
        public List<SalesMasterVO> GetAllSM()
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            List<SalesMasterVO> list = dac.GetAllSM();
            dac.Dispose();

            return list;
        }

        // 특정 조회 
        //public SalesMasterVO GetOneItem(int itemID)
        //{
        //    SalesMasterDAC dac = new SalesMasterDAC();
        //    SalesMasterVO cmp = dac.GetOneItem(itemID);
        //    dac.Dispose();

        //    return cmp;
        //}

        // 부분 조회 
        public List<SalesMasterVO> GetPartialSM(DateTime StartDate, DateTime EndDate, string companyName)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            List<SalesMasterVO> list = dac.GetPartialSM(StartDate, EndDate, companyName); // 부분 인수
            dac.Dispose();

            return list;
        }

        public bool UpdateSM(SalesMasterVO smVO)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            bool result = dac.UpdateSM(smVO);
            dac.Dispose();

            return result;
        }

        public bool DeleteSM(int SalesMasterID)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            bool result = dac.DeleteSM(SalesMasterID);
            dac.Dispose();

            return result;
        }
    }
}
