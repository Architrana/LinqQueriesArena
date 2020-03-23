using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueriesArena
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"a,b,c,d" + System.Environment.NewLine + "1,2,3,4";
            string[] arrStr = str.Split('\n');
                bool isColumnSet = false;
            System.Data.DataTable dtConnectionTable = new System.Data.DataTable();
            foreach (string item in arrStr)
            {
                if (!isColumnSet)
                {
                    foreach (string j in item.Split(',')) { dtConnectionTable.Columns.Add(j); }
                    isColumnSet = true;
                }
                else {
                    System.Data.DataRow dr = dtConnectionTable.NewRow();
                    dr.ItemArray = item.Split(',');
                    dtConnectionTable.Rows.Add(dr);
                }

            }

            foreach (System.Data.DataRow item in dtConnectionTable.Rows)
            {
                string strRow = "";
                foreach (string j in item.ItemArray) { strRow = strRow + ","+ j ; }
                Console.WriteLine(strRow);
            }
            Console.Read();
        }
    }
}
