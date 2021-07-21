using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FinalProject1_winform
{
    public class ExcelUtil
    {
        public static bool ExportExcelToList<T>(List<T> dataList, string saveFileName, string exceptColumns)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                //List VO의 속성명 엑셀의 첫번째 행에 추가
                int columnIndex = 0;

                foreach (PropertyInfo prop in typeof(T).GetProperties())
                {
                    if (!exceptColumns.Contains(prop.Name))
                    {
                        columnIndex++;
                        xlSheet.Cells[1, columnIndex] = prop.Name;
                    }
                }

                // 엑셀 시트 1열 속성 (색, 폰트, 정렬)
                Range rg = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, columnIndex]];
                rg.Interior.Color = Color.FromArgb(5, 91, 156);
                rg.Font.Color = Color.White;
                rg.HorizontalAlignment = 3;

                //List VO의 건수만큼 컬럼별로 셀에 추가
                for (int r = 0; r < dataList.Count; r++)
                {
                    columnIndex = 0;
                    foreach (PropertyInfo prop in typeof(T).GetProperties())
                    {
                        if (!exceptColumns.Contains(prop.Name))
                        {
                            columnIndex++;
                            if (prop.GetValue(dataList[r], null) != null)
                            {
                                xlSheet.Cells[r + 2, columnIndex] = prop.GetValue(dataList[r], null).ToString();
                            }
                        }
                    }
                }

                //엑셀컬럼의 너비가 데이터길이에 따라서 자동조정
                xlSheet.Columns.AutoFit();

                xlWorkBook.SaveAs(saveFileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
