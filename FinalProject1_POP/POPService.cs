﻿using System;
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

        public List<POPUserVO> GetUserWork(string userId, string workDate)
        {
            POPDAC dac = new POPDAC();
            List<POPUserVO> list = dac.GetUserWork(userId, workDate);
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

        public List<POPWorkOrderVO> GetWorkOrder(string workOrderId)
        {
            POPDAC dac = new POPDAC();
            List<POPWorkOrderVO> list = dac.GetWorkOrder(workOrderId);
            dac.Dispose();
            return list;
        }

        public List<POPWorkOrderVO> GetStartWork(string workOrderId)
        {
            POPDAC dac = new POPDAC();
            List<POPWorkOrderVO> list = dac.GetStartWork(workOrderId);
            dac.Dispose();
            return list;
        }

        //선택 조회
        public List<POPUserVO> GetWOSearch(string userId, string workDate, int processId, int itemId)
        {
            POPDAC dac = new POPDAC();
            List<POPUserVO> list = dac.GetWOSearch(userId, workDate, processId, itemId);
            dac.Dispose();

            return list;
        }

        public bool UpdateWorkStart(string workNum, string status)
        {
            POPDAC dac = new POPDAC();
            bool result = dac.UpdateWorkStart(workNum, status);
            dac.Dispose();
            return result;
        }

        public bool SaveWorkRecord(string workNum, string date, string itemCode, string status, int workQty, int okQty, int ngQty)
        {
            POPDAC dac = new POPDAC();
            bool result = dac.SaveWorkRecord(workNum, date, itemCode, status, workQty, okQty, ngQty);
            dac.Dispose();
            return result;
        }
    }
}
