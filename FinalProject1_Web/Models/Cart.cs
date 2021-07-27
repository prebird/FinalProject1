using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject1_VO;

namespace FinalProject1_Web.Models
{
    public class CartLine
    {
        public ItemVO Product { get; set; }
        public int Qty { get; set; }
    }

    public class Cart
    {
        List<CartLine> lines = new List<CartLine>();
        public List<CartLine> Lines { get { return lines; } }

        public void AddItem(ItemVO prd, int qty)
        {
            //목록중에 추가할 제품을 검색해서 첫번째 제품을 반환 (못찾은 경우 null, 찾은경우는 첫번째항목)
            CartLine line = lines.Where<CartLine>((p) => p.Product.Item_ID == prd.Item_ID).FirstOrDefault();

            if (line == null)
            {
                lines.Add(new CartLine
                {
                    Product = prd,
                    Qty = qty
                });
            }
            else
            {
                line.Qty = line.Qty + qty;
            }
        }

        public decimal CalcTotalValue()
        {
            //return lines.Sum<CartLine>((p) => p.Product.Price * p.Qty);
            return lines.Sum<CartLine>((p) => p.Product.price_present * p.Qty);

        }
    }
}