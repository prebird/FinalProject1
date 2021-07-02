using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    class ItemService
    {
        // 전체 조회
        public List<ItemVO> GetAllItem()
        {
            ItemDAC dac = new ItemDAC();
            List<ItemVO> list = dac.GetAllItem();
            dac.Dispose();

            return list;
        }

        // 특정 조회 
        public ItemVO GetOneItem(int itemID)
        {
            ItemDAC dac = new ItemDAC();
            ItemVO cmp = dac.GetOneItem(itemID);
            dac.Dispose();

            return cmp;
        }

        // 부분 조회
        public List<ItemVO> GetPartialItem(string itemType, string itemName, string inHouse, string outHouse, string yn) // 부분 인수
        {
            ItemDAC dac = new ItemDAC();
            List<ItemVO> list = dac.GetPartialItem(itemType, itemName, inHouse, outHouse, yn); // 부분 인수
            dac.Dispose();

            return list;
        }

        // 등록, 수정
        public bool InsertUpdateItem(ItemVO item)
        {
            ItemDAC dac = new ItemDAC();
            bool result = dac.InsertUpdateItem(item);
            dac.Dispose();

            return result;
        }

        // 삭제
        public bool Deleteitem(int itemID)
        {
            ItemDAC dac = new ItemDAC();
            bool result = dac.DeleteItem(itemID);
            dac.Dispose();
            return result;
        }


    }
}
