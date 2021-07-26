using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_Web.Controllers
{
    public class MainController : Controller
    {

        // GET: Main
        public ActionResult Index()
        {

            // 에어리어 차트용
            ItemDAC dac = new ItemDAC();
            List<OrderStatsVO> list = dac.GetOrderBestProduct();
            var statGroup = from stat in list
                            orderby stat.MM
                            group stat by stat.ProductName;

            int k = 1;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (var prodGroup in statGroup)
            {
                List<int> qtys = new List<int>();
                foreach (var prodStat in prodGroup)
                {
                    qtys.Add(prodStat.Qty);

                    if (k == 1)
                        sb.Append(prodStat.MM + "월,");
                }

                if (k == 1)
                {
                    ViewBag.Label1 = prodGroup.Key;
                    ViewBag.data1 = "[" + string.Join(",", qtys) + "]";
                }
                else if (k == 2)
                {
                    ViewBag.Label2 = prodGroup.Key;
                    ViewBag.data2 = "[" + string.Join(",", qtys) + "]";
                }
                else if (k == 3)
                {
                    ViewBag.Label3 = prodGroup.Key;
                    ViewBag.data3 = "[" + string.Join(",", qtys) + "]";
                }

                k++;
            }


            // 파이차트 용
            var sums = from stat in list
                       group stat by stat.ProductName into g
                       select new OrderStatsVO
                       {
                           ProductName = g.First().ProductName,
                           Qty = g.Sum(q => q.Qty)
                       };

            List<OrderStatsVO> listForPie = sums.ToList();

            List<string> pielabelList = new List<string>();
            List<int> pieQtyList = new List<int>();

            foreach (var item in listForPie)
            {
                pielabelList.Add(item.ProductName);
                pieQtyList.Add(item.Qty);
            }

            ViewBag.PieLabels = string.Join(",", pielabelList); // 물품1, 물품2, 물품3
            ViewBag.PieQty = "[" + string.Join(",", pieQtyList) + "]";



            ViewBag.Labels = sb.ToString().TrimEnd(','); // "1월,2월,3월,....12월"

            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }

        // 로그인 성공시  
        public ActionResult LoginSuccess()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}