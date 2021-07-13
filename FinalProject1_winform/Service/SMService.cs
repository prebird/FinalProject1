﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    class SMService
    {
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

        //// 부분 조회 
        //public List<SalesMasterVO> GetPartialItem(string itemCategory, string itemName, string yn) // 부분 인수
        //{
        //    SalesMasterDAC dac = new SalesMasterDAC();
        //    List<SalesMasterVO> list = dac.GetPartialItem(itemCategory, itemName, yn); // 부분 인수
        //    dac.Dispose();

        //    return list;
        //}

    }
}
